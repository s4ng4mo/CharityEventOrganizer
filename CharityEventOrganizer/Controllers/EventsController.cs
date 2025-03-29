using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using CharityEventOrganizer.Data;
using CharityEventOrganizer.Models.Entities;
using CharityEventOrganizer.Models.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace CharityEventOrganizer.Controllers
{
    public class EventsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public EventsController(
            ApplicationDbContext context,
            UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Events
        public async Task<IActionResult> Index()
        {
            var events = await _context.Events
                .Include(e => e.Cause)
                .Include(e => e.Organizer)
                .Where(e => e.Status == EventStatus.Approved)
                .ToListAsync();

            return View(events);
        }

        // GET: Events/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = await _context.Events
                .Include(e => e.Cause)
                .Include(e => e.Organizer)
                .Include(e => e.Sponsor)
                .Include(e => e.Comments)
                    .ThenInclude(c => c.User)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (@event == null)
            {
                return NotFound();
            }

            return View(@event);
        }

        // GET: Events/Create
        [Authorize]
        public IActionResult Create()
        {
            ViewData["CauseId"] = new SelectList(_context.Causes, "Id", "Name");
            return View();
        }

        // POST: Events/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create(EventViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);

                var newEvent = new Event
                {
                    Title = model.Title,
                    Description = model.Description,
                    EventDate = model.EventDate,
                    Location = model.Location,
                    CauseId = model.CauseId,
                    OrganizerId = user.Id,
                    Status = EventStatus.Submitted,
                    CreatedDate = DateTime.Now
                };

                _context.Add(newEvent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(MySubmissions));
            }

            ViewData["CauseId"] = new SelectList(_context.Causes, "Id", "Name", model.CauseId);
            return View(model);
        }

        // GET: Events/MySubmissions
        [Authorize]
        public async Task<IActionResult> MySubmissions()
        {
            var user = await _userManager.GetUserAsync(User);

            var myEvents = await _context.Events
                .Include(e => e.Cause)
                .Where(e => e.OrganizerId == user.Id)
                .OrderByDescending(e => e.CreatedDate)
                .ToListAsync();

            return View(myEvents);
        }
    }
}