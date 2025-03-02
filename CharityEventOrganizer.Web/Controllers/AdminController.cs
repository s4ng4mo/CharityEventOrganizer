using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CharityEventOrganizer.Core.Entities;
using CharityEventOrganizer.Infrastructure.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CharityEventOrganizer.Web.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Dashboard
        public async Task<IActionResult> Dashboard()
        {
            var pendingSubmissions = await _context.EventSubmissions
                .Include(s => s.Event)
                .Include(s => s.Submitter)
                .Where(s => s.Status == SubmissionStatus.Pending)
                .OrderBy(s => s.SubmittedAt)
                .ToListAsync();

            ViewBag.PendingCount = pendingSubmissions.Count;

            var recentApprovals = await _context.EventSubmissions
                .Include(s => s.Event)
                .Include(s => s.Submitter)
                .Where(s => s.Status == SubmissionStatus.Approved && s.ReviewedAt != null)
                .OrderByDescending(s => s.ReviewedAt)
                .Take(5)
                .ToListAsync();

            ViewBag.RecentApprovals = recentApprovals;
            ViewBag.RecentApprovalCount = recentApprovals.Count;

            var publishedEvents = await _context.Events
                .Where(e => e.IsPublished)
                .CountAsync();

            ViewBag.PublishedCount = publishedEvents;

            return View(pendingSubmissions);
        }

        // GET: Admin/ReviewSubmission/5
        public async Task<IActionResult> ReviewSubmission(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var submission = await _context.EventSubmissions
                .Include(s => s.Event)
                .Include(s => s.Submitter)
                .FirstOrDefaultAsync(m => m.Id == id && m.Status == SubmissionStatus.Pending);

            if (submission == null)
            {
                return NotFound();
            }

            return View(submission);
        }

        // POST: Admin/ApproveSubmission/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ApproveSubmission(int id)
        {
            var submission = await _context.EventSubmissions.FindAsync(id);

            if (submission == null || submission.Status != SubmissionStatus.Pending)
            {
                return NotFound();
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            submission.Status = SubmissionStatus.Approved;
            submission.AdminId = userId;
            submission.ReviewedAt = DateTime.UtcNow;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Dashboard));
        }

        // POST: Admin/RejectSubmission/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RejectSubmission(int id, string rejectionReason)
        {
            var submission = await _context.EventSubmissions.FindAsync(id);

            if (submission == null || submission.Status != SubmissionStatus.Pending)
            {
                return NotFound();
            }

            if (string.IsNullOrWhiteSpace(rejectionReason))
            {
                ModelState.AddModelError("", "Rejection reason is required.");
                return View("ReviewSubmission", await _context.EventSubmissions
                    .Include(s => s.Event)
                    .Include(s => s.Submitter)
                    .FirstOrDefaultAsync(m => m.Id == id));
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            submission.Status = SubmissionStatus.Rejected;
            submission.RejectionReason = rejectionReason;
            submission.AdminId = userId;
            submission.ReviewedAt = DateTime.UtcNow;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Dashboard));
        }
    }
}