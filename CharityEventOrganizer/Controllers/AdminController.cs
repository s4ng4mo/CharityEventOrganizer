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
                .OrderByDescending(u => u.OrganizedEvents.Count)
                .ToListAsync();

            return View(users);
        }

        // GET: Admin/SponsorManagement
        public async Task<IActionResult> SponsorManagement()
        {
            var sponsors = await _context.Sponsors
                .Include(s => s.User)
                .ToListAsync();

            return View(sponsors);
        }

        // GET: Admin/AllEvents
        public async Task<IActionResult> AllEvents()
        {
            var events = await _context.Events
                .Include(e => e.Organizer)
                .Include(e => e.Cause)
                .OrderByDescending(e => e.CreatedDate)
                .ToListAsync();

            return View(events);
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