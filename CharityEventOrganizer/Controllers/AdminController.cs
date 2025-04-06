using System;
using System.Linq;
using System.Threading.Tasks;
using CharityEventOrganizer.Data;
using CharityEventOrganizer.Models.Entities;
using CharityEventOrganizer.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CharityEventOrganizer.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AdminController(
            ApplicationDbContext context,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        // GET: Admin/Dashboard
        public async Task<IActionResult> Dashboard()
        {
            var dashboardViewModel = new AdminDashboardViewModel
            {
                EventsPendingReview = await _context.Events
                    .Where(e => e.Status == EventStatus.Submitted)
                    .CountAsync(),
                TotalUsers = await _userManager.Users.CountAsync(),
                TotalSponsors = await _context.Sponsors.CountAsync(),
                TotalApprovedEvents = await _context.Events
                    .Where(e => e.Status == EventStatus.Approved || e.Status == EventStatus.SponsorshipDiscussion)
                    .CountAsync(),
                RecentEvents = await _context.Events
                    .Include(e => e.Organizer)
                    .Include(e => e.Cause)
                    .OrderByDescending(e => e.CreatedDate)
                    .Take(5)
                    .ToListAsync()
            };

            return View(dashboardViewModel);
        }

        // GET: Admin/EventReview
        public async Task<IActionResult> EventReview()
        {
            var pendingEvent = await _context.Events
                .Include(e => e.Organizer)
                .Include(e => e.Cause)
                .Where(e => e.Status == EventStatus.Submitted)
                .OrderBy(e => e.CreatedDate)
                .FirstOrDefaultAsync();

            if (pendingEvent == null)
            {
                return View("NoEventsToReview");
            }

            return View(pendingEvent);
        }

        // POST: Admin/ApproveEvent/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ApproveEvent(int id)
        {
            var eventToApprove = await _context.Events.FindAsync(id);

            if (eventToApprove == null)
            {
                return NotFound();
            }

            eventToApprove.Status = EventStatus.ApprovedForSponsorship;

            _context.Update(eventToApprove);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(EventReview));
        }

        // POST: Admin/RejectEvent/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RejectEvent(int id)
        {
            var eventToReject = await _context.Events.FindAsync(id);

            if (eventToReject == null)
            {
                return NotFound();
            }

            eventToReject.Status = EventStatus.Rejected;

            _context.Update(eventToReject);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(EventReview));
        }

        // GET: Admin/UserManagement
        public async Task<IActionResult> UserManagement()
        {
            var users = await _userManager.Users
                .Include(u => u.OrganizedEvents) // Eagerly load the OrganizedEvents collection
                .OrderByDescending(u => u.OrganizedEvents.Count())
                .ToListAsync();

            return View(users);
        }

        // POST: Admin/MakeAdmin
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> MakeAdmin(string userId)
        {
            if (string.IsNullOrEmpty(userId))
            {
                TempData["ErrorMessage"] = "User ID is required";
                return RedirectToAction(nameof(UserManagement));
            }

            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                TempData["ErrorMessage"] = "User not found";
                return RedirectToAction(nameof(UserManagement));
            }

            // Check if user is already an admin
            if (await _userManager.IsInRoleAsync(user, "Admin"))
            {
                TempData["ErrorMessage"] = "User is already an administrator";
                return RedirectToAction(nameof(UserManagement));
            }

            // Add user to Admin role
            var result = await _userManager.AddToRoleAsync(user, "Admin");
            if (result.Succeeded)
            {
                TempData["SuccessMessage"] = $"Admin privileges granted to {user.UserName} successfully";
            }
            else
            {
                TempData["ErrorMessage"] = $"Failed to grant admin privileges: {string.Join(", ", result.Errors.Select(e => e.Description))}";
            }

            return RedirectToAction(nameof(UserManagement));
        }

        // POST: Admin/RemoveAdmin
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RemoveAdmin(string userId)
        {
            if (string.IsNullOrEmpty(userId))
            {
                TempData["ErrorMessage"] = "User ID is required";
                return RedirectToAction(nameof(UserManagement));
            }

            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                TempData["ErrorMessage"] = "User not found";
                return RedirectToAction(nameof(UserManagement));
            }

            // Prevent removing admin role from yourself
            if (user.Id == _userManager.GetUserId(User))
            {
                TempData["ErrorMessage"] = "You cannot remove your own admin privileges";
                return RedirectToAction(nameof(UserManagement));
            }

            // Check if user is an admin
            if (!await _userManager.IsInRoleAsync(user, "Admin"))
            {
                TempData["ErrorMessage"] = "User is not an administrator";
                return RedirectToAction(nameof(UserManagement));
            }

            // Remove user from Admin role
            var result = await _userManager.RemoveFromRoleAsync(user, "Admin");
            if (result.Succeeded)
            {
                TempData["SuccessMessage"] = $"Admin privileges removed from {user.UserName} successfully";
            }
            else
            {
                TempData["ErrorMessage"] = $"Failed to remove admin privileges: {string.Join(", ", result.Errors.Select(e => e.Description))}";
            }

            return RedirectToAction(nameof(UserManagement));
        }

        // GET: Admin/SponsorManagement
        public async Task<IActionResult> SponsorManagement()
        {
            var sponsors = await _context.Sponsors
                .Include(s => s.User)
                .Include(s => s.SponsoredEvents) // Eagerly load sponsored events
                .ToListAsync();

            var users = await _userManager.Users
                .Where(u => !_context.Sponsors.Select(s => s.UserId).Contains(u.Id))
                .ToListAsync();

            ViewBag.AvailableUsers = users;

            return View(sponsors);
        }

        // POST: Admin/AddSponsor
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddSponsor(string Name, string Description, string Website, string UserId)
        {
            // Validation
            if (string.IsNullOrEmpty(Name))
            {
                TempData["ErrorMessage"] = "Sponsor name is required";
                return RedirectToAction(nameof(SponsorManagement));
            }

            if (string.IsNullOrEmpty(UserId))
            {
                TempData["ErrorMessage"] = "Please select a user";
                return RedirectToAction(nameof(SponsorManagement));
            }

            // Get the selected user
            var user = await _userManager.FindByIdAsync(UserId);
            if (user == null)
            {
                TempData["ErrorMessage"] = "Selected user not found";
                return RedirectToAction(nameof(SponsorManagement));
            }

            // Check if user is already a sponsor
            var existingSponsor = await _context.Sponsors.FirstOrDefaultAsync(s => s.UserId == UserId);
            if (existingSponsor != null)
            {
                TempData["ErrorMessage"] = "Selected user is already a sponsor";
                return RedirectToAction(nameof(SponsorManagement));
            }

            // Assign the Sponsor role if they don't already have it
            if (!await _userManager.IsInRoleAsync(user, "Sponsor"))
            {
                await _userManager.AddToRoleAsync(user, "Sponsor");
            }

            // Create the sponsor entity
            var sponsor = new Sponsor
            {
                Name = Name,
                Description = Description,
                Website = Website,
                UserId = UserId
            };

            _context.Sponsors.Add(sponsor);
            await _context.SaveChangesAsync();

            TempData["SuccessMessage"] = "Sponsor added successfully";
            return RedirectToAction(nameof(SponsorManagement));
        }

        // POST: Admin/DeleteSponsor
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteSponsor(int sponsorId)
        {
            var sponsor = await _context.Sponsors
                .Include(s => s.SponsoredEvents)
                .FirstOrDefaultAsync(s => s.Id == sponsorId);

            if (sponsor == null)
            {
                TempData["ErrorMessage"] = "Sponsor not found";
                return RedirectToAction(nameof(SponsorManagement));
            }

            try
            {
                // Get the associated user
                var user = await _userManager.FindByIdAsync(sponsor.UserId);

                // Remove sponsorship from events
                var sponsoredEvents = _context.Events.Where(e => e.SponsorId == sponsorId);
                foreach (var evt in sponsoredEvents)
                {
                    evt.SponsorId = null;
                    // If the event was in sponsorship discussion, update the status
                    if (evt.Status == EventStatus.SponsorshipDiscussion)
                    {
                        evt.Status = EventStatus.ApprovedForSponsorship;
                    }
                }

                // Remove the sponsor entity
                _context.Sponsors.Remove(sponsor);
                await _context.SaveChangesAsync();

                // Remove the Sponsor role from the user if no other sponsor entities reference this user
                if (user != null && !await _context.Sponsors.AnyAsync(s => s.UserId == user.Id))
                {
                    await _userManager.RemoveFromRoleAsync(user, "Sponsor");
                }

                TempData["SuccessMessage"] = $"Sponsor '{sponsor.Name}' has been deleted successfully";
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Error deleting sponsor: {ex.Message}";
            }

            return RedirectToAction(nameof(SponsorManagement));
        }

        // POST: Admin/EditSponsor
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditSponsor(int sponsorId, string Name, string Description, string Website)
        {
            var sponsor = await _context.Sponsors.FindAsync(sponsorId);

            if (sponsor == null)
            {
                TempData["ErrorMessage"] = "Sponsor not found";
                return RedirectToAction(nameof(SponsorManagement));
            }

            if (string.IsNullOrEmpty(Name))
            {
                TempData["ErrorMessage"] = "Sponsor name is required";
                return RedirectToAction(nameof(SponsorManagement));
            }

            try
            {
                // Update the sponsor properties
                sponsor.Name = Name;
                sponsor.Description = Description;
                sponsor.Website = Website;

                _context.Update(sponsor);
                await _context.SaveChangesAsync();

                TempData["SuccessMessage"] = "Sponsor updated successfully";
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Error updating sponsor: {ex.Message}";
            }

            return RedirectToAction(nameof(SponsorManagement));
        }

        // POST: Admin/DeleteUser
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteUser(string userId)
        {
            if (string.IsNullOrEmpty(userId))
            {
                return BadRequest("User ID is required");
            }

            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound($"User with ID {userId} not found");
            }

            // Delete related data first (events, comments, etc.)
            // You may need to adjust this based on your specific relationships
            var userEvents = _context.Events.Where(e => e.OrganizerId == userId);
            _context.Events.RemoveRange(userEvents);

            var userComments = _context.Comments.Where(c => c.UserId == userId);
            _context.Comments.RemoveRange(userComments);

            // Check if user is a sponsor
            var sponsor = await _context.Sponsors.FirstOrDefaultAsync(s => s.UserId == userId);
            if (sponsor != null)
            {
                _context.Sponsors.Remove(sponsor);
            }

            await _context.SaveChangesAsync();

            // Now delete the user
            var result = await _userManager.DeleteAsync(user);
            if (result.Succeeded)
            {
                // Success - redirect back to user management
                return RedirectToAction(nameof(UserManagement));
            }

            // If we get here, something went wrong
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            // Redirect back to the user management page with errors
            return RedirectToAction(nameof(UserManagement));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AssignRole(string userId, string roleName)
        {
            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(roleName))
            {
                return BadRequest("User ID and Role Name are required");
            }

            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound($"User with ID {userId} not found");
            }

            // Check if role exists
            if (!await _roleManager.RoleExistsAsync(roleName))
            {
                return BadRequest($"Role {roleName} does not exist");
            }

            // Add user to role
            var result = await _userManager.AddToRoleAsync(user, roleName);
            if (result.Succeeded)
            {
                return RedirectToAction(nameof(UserManagement));
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            return RedirectToAction(nameof(UserManagement));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RemoveRole(string userId, string roleName)
        {
            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(roleName))
            {
                return BadRequest("User ID and Role Name are required");
            }

            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound($"User with ID {userId} not found");
            }

            // Check if user is in role
            if (await _userManager.IsInRoleAsync(user, roleName))
            {
                var result = await _userManager.RemoveFromRoleAsync(user, roleName);
                if (result.Succeeded)
                {
                    return RedirectToAction(nameof(UserManagement));
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return RedirectToAction(nameof(UserManagement));
        }
    }
}