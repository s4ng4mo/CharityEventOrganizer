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
    public class EventsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EventsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Events
        public async Task<IActionResult> Index()
        {
            var publishedEvents = await _context.Events
                .Where(e => e.IsPublished)
                .Include(e => e.Organizer)
                .OrderByDescending(e => e.PublishedAt)
                .ToListAsync();

            return View(publishedEvents);
        }

        // GET: Events/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = await _context.Events
                .Include(e => e.Organizer)
                .Include(e => e.EventSponsors)
                .ThenInclude(es => es.Sponsor)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (@event == null || !@event.IsPublished)
            {
                return NotFound();
            }

            return View(@event);
        }

        // GET: Events/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Events/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create([Bind("Title,Description,EventDate,Location,ImageUrl")] Event @event)
        {
            if (ModelState.IsValid)
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                @event.OrganizerId = userId;
                @event.CreatedAt = DateTime.UtcNow;

                _context.Add(@event);
                await _context.SaveChangesAsync();

                // Create a submission for this event
                var submission = new EventSubmission
                {
                    EventId = @event.Id,
                    SubmitterId = userId,
                    Status = SubmissionStatus.Pending
                };

                _context.Add(submission);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(MySubmissions));
            }
            return View(@event);
        }

        // GET: Events/MySubmissions
        [Authorize]
        public async Task<IActionResult> MySubmissions()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var submissions = await _context.EventSubmissions
                .Include(s => s.Event)
                .Where(s => s.SubmitterId == userId)
                .OrderByDescending(s => s.SubmittedAt)
                .ToListAsync();

            return View(submissions);
        }
    }
}