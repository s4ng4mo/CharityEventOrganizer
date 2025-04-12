using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using CharityEventOrganizer.Models.Entities;
using CharityEventOrganizer.Data;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace CharityEventOrganizer.Controllers
{
    public class CommentController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public CommentController(
            ApplicationDbContext context,
            UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int eventId, string content)
        {
            if (string.IsNullOrWhiteSpace(content))
            {
                return Json(new { success = false, message = "Comment cannot be empty" });
            }

            // Check for inappropriate content
            if (ContainsInappropriateContent(content))
            {
                return Json(new { success = false, message = "Your comment contains inappropriate language. Please revise and try again." });
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
            {
                return Json(new { success = false, message = "User not found" });
            }

            var comment = new Comment
            {
                Content = content,
                CreatedDate = DateTime.Now,
                EventId = eventId,
                UserId = userId
            };

            try
            {
                _context.Comments.Add(comment);
                await _context.SaveChangesAsync();

                // Return data needed to render the new comment
                return Json(new
                {
                    success = true,
                    comment = new
                    {
                        id = comment.Id,
                        content = comment.Content,
                        createdDate = comment.CreatedDate.ToString("MMM d, yyyy at h:mm tt"),
                        userName = user.UserName,
                        userInitial = user.UserName.Substring(0, 1).ToUpper()
                        // Removed profilePicturePath
                    }
                });
            }
            catch (Exception)
            {
                return Json(new { success = false, message = "Failed to add comment. Please try again." });
            }
        }

        private bool ContainsInappropriateContent(string content)
        {
            // Convert to lowercase for case-insensitive matching
            string normalizedContent = content.ToLower();

            // Pre-process content to catch common evasion tactics
            normalizedContent = ReplaceCommonEvasions(normalizedContent);

            // Check against inappropriate content patterns
            var patterns = GetInappropriatePatterns();

            foreach (var pattern in patterns)
            {
                if (Regex.IsMatch(normalizedContent, pattern, RegexOptions.IgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

        private string ReplaceCommonEvasions(string content)
        {
            // Replace numbers and symbols used to evade filters
            content = Regex.Replace(content, "0", "o");
            content = Regex.Replace(content, "1", "i");
            content = Regex.Replace(content, "3", "e");
            content = Regex.Replace(content, "4", "a");
            content = Regex.Replace(content, "5", "s");
            content = Regex.Replace(content, "@", "a");
            content = Regex.Replace(content, "\\$", "s");

            // Remove repeated characters (e.g., "f***k" becomes "fk")
            content = Regex.Replace(content, "\\*+", "");

            // Replace spaces or dots between letters (e.g., "f.u.c.k" becomes "fuck")
            content = Regex.Replace(content, "([a-z])[\\s.*]+([a-z])", "$1$2");

            return content;
        }

        private List<string> GetInappropriatePatterns()
        {
            // Regex patterns for inappropriate content
            // Using word boundaries (\b) to avoid false positives
            return new List<string>
            {
                // Profanity
                @"\b(f+u+c+k+)\b|\bf+k\b|\bf\s*u\s*c\s*k+",
                @"\bs+h+[i1!]+t+\b|\bs+h+[i1!]+\b",
                @"\ba+s+h+[o0]+l+[e3]+\b",
                @"\bb+[i1!]+t+c+h+\b",
                @"\bd+[i1!]+c+k+\b",
                @"\bt+w+a+t+\b",
                @"\bc+u+n+t+\b",
                @"\bp+[i1!]+s+s+\b",
                
                // Racial/discriminatory terms
                @"\bn+[i1!]+g+[e3]+r+\b",
                @"\bf+a+g+([o0]+t+)?\b",
                @"\br+e+t+a+r+d+\b",
                
                // Sexual explicit content
                @"\bp+[o0]+r+n+\b",
                @"\bp+[e3]+n+[i1!]+s+\b",
                @"\bv+a+g+[i1!]+n+a+\b",
                @"\bs+[e3]+x+\b",
                
                // Drugs
                @"\bc+[o0]+c+a+[i1!]+n+[e3]+\b",
                @"\bh+[e3]+r+[o0]+[i1!]+n+\b",
                @"\bm+[e3]+t+h+\b",
                
                // Violence
                @"\bk+[i1!]+l+l+\b",
                @"\bm+u+r+d+[e3]+r+\b",
                @"\br+a+p+[e3]+\b",
                @"\bs+u+[i1!]+c+[i1!]+d+[e3]+\b"
            };
        }
    }
}