using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using CharityEventOrganizer.Data;
using CharityEventOrganizer.Models.Entities;
using CharityEventOrganizer.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CharityEventOrganizer.Controllers
{
    [Authorize]
    public class MessageController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private static readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions
        {
            ReferenceHandler = ReferenceHandler.Preserve,
            MaxDepth = 64
        };


        public MessageController(
            ApplicationDbContext context,
            UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Message/GetMessages/5
        // Replace or update the GetMessages method in MessageController.cs

        // Update GetMessages method in MessageController.cs

        [HttpGet]
        public async Task<IActionResult> GetMessages(int eventId)
        {
            try
            {
                Console.WriteLine($"GetMessages called for eventId: {eventId}");

                var currentUser = await _userManager.GetUserAsync(User);
                if (currentUser == null)
                {
                    return BadRequest("User not found");
                }

                Console.WriteLine($"Current user: {currentUser.Id} ({currentUser.UserName})");

                var eventEntity = await _context.Events
                    .Include(e => e.Organizer)
                    .Include(e => e.Sponsor)
                    .ThenInclude(s => s.User)
                    .FirstOrDefaultAsync(e => e.Id == eventId);

                if (eventEntity == null)
                {
                    return BadRequest($"Event with ID {eventId} not found");
                }

                Console.WriteLine($"Found event: {eventEntity.Title}, Organizer: {eventEntity.OrganizerId}, SponsorId: {eventEntity.SponsorId}");

                // Check if user is authorized to view messages
                bool isOrganizer = eventEntity.OrganizerId == currentUser.Id;
                bool isSponsor = eventEntity.Sponsor != null && eventEntity.Sponsor.UserId == currentUser.Id;

                Console.WriteLine($"User roles: isOrganizer={isOrganizer}, isSponsor={isSponsor}");

                if (!isOrganizer && !isSponsor)
                {
                    return BadRequest($"User {currentUser.UserName} is not authorized to view messages for this event");
                }

                // Determine the other party in the conversation
                string otherPartyId = isOrganizer ? eventEntity.Sponsor?.UserId : eventEntity.OrganizerId;

                Console.WriteLine($"Other party ID: {otherPartyId}");

                if (string.IsNullOrEmpty(otherPartyId))
                {
                    return BadRequest("No conversation partner found. Event may not be in discussion state.");
                }

                // Get all messages for this event, regardless of sender/recipient
                var allMessages = await _context.Messages
                    .Where(m => m.EventId == eventId)
                    .OrderBy(m => m.SentAt)
                    .ToListAsync();

                Console.WriteLine($"Total messages found for event: {allMessages.Count}");

                foreach (var msg in allMessages)
                {
                    Console.WriteLine($"Message ID: {msg.Id}, Sender: {msg.SenderId}, Recipient: {msg.RecipientId}, Content: {msg.Content.Substring(0, Math.Min(msg.Content.Length, 20))}...");
                }

                // Filter messages that involve the current user
                var messages = allMessages.Where(m =>
                    (m.SenderId == currentUser.Id && m.RecipientId == otherPartyId) ||
                    (m.SenderId == otherPartyId && m.RecipientId == currentUser.Id))
                    .ToList();

                Console.WriteLine($"Filtered messages: {messages.Count}");

                // Mark unread messages as read
                var unreadMessages = messages.Where(m => m.RecipientId == currentUser.Id && !m.IsRead).ToList();
                foreach (var message in unreadMessages)
                {
                    message.IsRead = true;
                }
                await _context.SaveChangesAsync();

                // Set the IsFromSponsor flag for UI rendering
                foreach (var message in messages)
                {
                    // If the organizer is viewing, messages from sponsor will have IsFromSponsor=true
                    if (isOrganizer)
                    {
                        message.IsFromSponsor = message.SenderId == otherPartyId;
                    }
                    // If the sponsor is viewing, messages from sponsor (self) will have IsFromSponsor=true
                    else
                    {
                        message.IsFromSponsor = message.SenderId == currentUser.Id;
                    }
                }

                // Get user/sponsor info for the other party
                string otherPartyName;
                string otherPartyInitial;

                if (isOrganizer)
                {
                    otherPartyName = eventEntity.Sponsor?.Name ?? "Sponsor";
                    otherPartyInitial = string.IsNullOrEmpty(eventEntity.Sponsor?.Name)
                        ? "S"
                        : eventEntity.Sponsor.Name.Substring(0, 1).ToUpper();
                }
                else
                {
                    otherPartyName = eventEntity.Organizer?.UserName ?? "Organizer";
                    otherPartyInitial = string.IsNullOrEmpty(eventEntity.Organizer?.UserName)
                        ? "O"
                        : eventEntity.Organizer.UserName.Substring(0, 1).ToUpper();
                }

                // Create a simplified DTO to avoid serialization issues
                var conversationInfo = new
                {
                    EventId = eventEntity.Id,
                    EventTitle = eventEntity.Title,
                    Messages = messages.Select(m => new {
                        Id = m.Id,
                        Content = m.Content,
                        SentAt = m.SentAt,
                        IsFromSponsor = m.IsFromSponsor,
                        SenderId = m.SenderId,
                        RecipientId = m.RecipientId
                    }).ToList(),
                    OtherPartyName = otherPartyName,
                    OtherPartyInitial = otherPartyInitial,
                    IsOrganizer = isOrganizer
                };

                return Json(conversationInfo);
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"Exception in GetMessages: {ex.Message}");
                Console.WriteLine($"Stack trace: {ex.StackTrace}");
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // POST: Message/SendMessage
        // Update the SendMessage method in MessageController.cs

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SendMessage(int eventId, string content)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(content))
                {
                    return BadRequest("Message content cannot be empty");
                }

                var currentUser = await _userManager.GetUserAsync(User);
                if (currentUser == null)
                {
                    return NotFound("User not found");
                }

                var eventEntity = await _context.Events
                    .Include(e => e.Organizer)
                    .Include(e => e.Sponsor)
                    .ThenInclude(s => s.User)
                    .FirstOrDefaultAsync(e => e.Id == eventId);

                if (eventEntity == null)
                {
                    return NotFound($"Event not found with ID: {eventId}");
                }

                // Check if user is authorized to send messages (must be either the organizer or the sponsor)
                bool isOrganizer = eventEntity.OrganizerId == currentUser.Id;
                bool isSponsor = eventEntity.Sponsor != null && eventEntity.Sponsor.UserId == currentUser.Id;

                if (!isOrganizer && !isSponsor)
                {
                    return Forbid($"User {currentUser.Id} is not authorized to send messages for this event {eventId}");
                }

                // Event must be in sponsorship discussion status
                if (eventEntity.Status != EventStatus.SponsorshipDiscussion)
                {
                    return BadRequest($"This event is not in sponsorship discussion status. Current status: {eventEntity.Status}");
                }

                // Determine the recipient
                string recipientId = isOrganizer ? eventEntity.Sponsor?.UserId : eventEntity.OrganizerId;

                if (string.IsNullOrEmpty(recipientId))
                {
                    return NotFound($"No recipient found. Organizer ID: {eventEntity.OrganizerId}, Sponsor User ID: {eventEntity.Sponsor?.UserId}");
                }

                // Log the message details before saving
                Console.WriteLine($"Saving message: EventID={eventId}, Sender={currentUser.Id}, Recipient={recipientId}, Content={content}");

                // Create and save the message
                var message = new Message
                {
                    EventId = eventId,
                    SenderId = currentUser.Id,
                    RecipientId = recipientId,
                    Content = content,
                    SentAt = DateTime.Now,
                    IsRead = false
                };

                _context.Messages.Add(message);

                // Save with explicit transaction to ensure it's committed
                using (var transaction = await _context.Database.BeginTransactionAsync())
                {
                    try
                    {
                        await _context.SaveChangesAsync();
                        await transaction.CommitAsync();
                        Console.WriteLine($"Message saved successfully with ID: {message.Id}");
                    }
                    catch (Exception ex)
                    {
                        await transaction.RollbackAsync();
                        Console.WriteLine($"Error saving message: {ex.Message}");
                        throw;
                    }
                }

                // Return the created message with additional metadata
                return Json(new
                {
                    id = message.Id,
                    content = message.Content,
                    sentAt = message.SentAt.ToString("MMM d, yyyy at h:mm tt"),
                    isFromSponsor = isSponsor,
                    senderName = currentUser.UserName,
                    senderInitial = currentUser.UserName.Substring(0, 1).ToUpper()
                });
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"Exception in SendMessage: {ex.Message}");
                Console.WriteLine($"Stack trace: {ex.StackTrace}");
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // GET: Message/GetUnreadCount
        [HttpGet]
        public async Task<IActionResult> GetUnreadCount()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            if (currentUser == null)
            {
                return NotFound("User not found");
            }

            var unreadCount = await _context.Messages
                .CountAsync(m => m.RecipientId == currentUser.Id && !m.IsRead);

            return Json(new { unreadCount });
        }
    }
}