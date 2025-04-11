using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using CharityEventOrganizer.Data;
using CharityEventOrganizer.Models.Entities;
using CharityEventOrganizer.Models.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace CharityEventOrganizer.Controllers
{
    [Authorize(Roles = "Sponsor")]
    public class SponsorController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public SponsorController(
            ApplicationDbContext context,
            UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Sponsor/Dashboard
        public async Task<IActionResult> Dashboard()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            if (currentUser == null)
            {
                return NotFound("User not found");
            }

            // Get the sponsor profile associated with the current user
            var sponsor = await _context.Sponsors
                .Include(s => s.SponsoredEvents)
                .ThenInclude(e => e.Cause)
                .FirstOrDefaultAsync(s => s.UserId == currentUser.Id);

            if (sponsor == null)
            {
                // Handle case where user has Sponsor role but no sponsor profile
                // This shouldn't happen in normal operation, but good to handle
                return RedirectToAction("CompleteProfile");
            }

            // Get events that need sponsorship
            var eventsNeedingSponsors = await _context.Events
                .Include(e => e.Organizer)
                .Include(e => e.Cause)
                .Where(e => e.Status == EventStatus.ApprovedForSponsorship)
                .OrderByDescending(e => e.CreatedDate)
                .Take(5)
                .ToListAsync();

            // Get events in discussion with this sponsor
            var eventsInDiscussion = await _context.Events
                .Include(e => e.Organizer)
                .Include(e => e.Cause)
                .Where(e => e.Status == EventStatus.SponsorshipDiscussion && e.SponsorId == sponsor.Id)
                .OrderByDescending(e => e.CreatedDate)
                .ToListAsync();

            var viewModel = new SponsorDashboardViewModel
            {
                Sponsor = sponsor,
                EventsNeedingSponsors = eventsNeedingSponsors,
                EventsInDiscussion = eventsInDiscussion,
                SponsoredEvents = sponsor.SponsoredEvents.ToList()
            };

            return View(viewModel);
        }

        // GET: Sponsor/EventsForSponsorship
        public async Task<IActionResult> EventsForSponsorship(string searchTerm = "", int? causeId = null, string sortBy = "date")
        {
            var currentUser = await _userManager.GetUserAsync(User);
            if (currentUser == null)
            {
                return NotFound("User not found");
            }

            var sponsor = await _context.Sponsors
                .FirstOrDefaultAsync(s => s.UserId == currentUser.Id);

            if (sponsor == null)
            {
                return RedirectToAction("CompleteProfile");
            }

            // Get all causes for filter dropdown
            var causes = await _context.Causes.ToListAsync();

            // Query events needing sponsors
            var eventsQuery = _context.Events
                .Include(e => e.Organizer)
                .Include(e => e.Cause)
                .Where(e => e.Status == EventStatus.ApprovedForSponsorship);

            // Apply search filters
            if (!string.IsNullOrEmpty(searchTerm))
            {
                searchTerm = searchTerm.ToLower();
                eventsQuery = eventsQuery.Where(e =>
                    e.Title.ToLower().Contains(searchTerm) ||
                    e.Description.ToLower().Contains(searchTerm) ||
                    e.Location.ToLower().Contains(searchTerm));
            }

            if (causeId.HasValue && causeId > 0)
            {
                eventsQuery = eventsQuery.Where(e => e.CauseId == causeId);
            }

            // Apply sorting
            switch (sortBy)
            {
                case "dateAsc":
                    eventsQuery = eventsQuery.OrderBy(e => e.EventDate);
                    break;
                case "name":
                    eventsQuery = eventsQuery.OrderBy(e => e.Title);
                    break;
                case "nameDesc":
                    eventsQuery = eventsQuery.OrderByDescending(e => e.Title);
                    break;
                default: // date desc is default
                    eventsQuery = eventsQuery.OrderByDescending(e => e.EventDate);
                    break;
            }

            var events = await eventsQuery.ToListAsync();

            var viewModel = new SponsorEventsViewModel
            {
                Events = events,
                Causes = causes,
                CurrentCauseId = causeId,
                SearchTerm = searchTerm,
                SortBy = sortBy
            };

            return View(viewModel);
        }

        // GET: Sponsor/SponsoredEvents
        public async Task<IActionResult> SponsoredEvents()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            if (currentUser == null)
            {
                return NotFound("User not found");
            }

            var sponsor = await _context.Sponsors
                .Include(s => s.SponsoredEvents)
                .ThenInclude(e => e.Cause)
                .Include(s => s.SponsoredEvents)
                .ThenInclude(e => e.Organizer)
                .FirstOrDefaultAsync(s => s.UserId == currentUser.Id);

            if (sponsor == null)
            {
                return RedirectToAction("CompleteProfile");
            }

            return View(sponsor);
        }

        // GET: Sponsor/EventDiscussions
        public async Task<IActionResult> EventDiscussions()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            if (currentUser == null)
            {
                return NotFound("User not found");
            }

            var sponsor = await _context.Sponsors
                .FirstOrDefaultAsync(s => s.UserId == currentUser.Id);

            if (sponsor == null)
            {
                return RedirectToAction("CompleteProfile");
            }

            var eventsInDiscussion = await _context.Events
                .Include(e => e.Organizer)
                .Include(e => e.Cause)
                .Where(e => e.Status == EventStatus.SponsorshipDiscussion && e.SponsorId == sponsor.Id)
                .OrderByDescending(e => e.CreatedDate)
                .ToListAsync();

            return View(eventsInDiscussion);
        }

        // GET: Sponsor/Profile
        public async Task<IActionResult> Profile()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            if (currentUser == null)
            {
                return NotFound("User not found");
            }

            var sponsor = await _context.Sponsors
                .FirstOrDefaultAsync(s => s.UserId == currentUser.Id);

            if (sponsor == null)
            {
                return RedirectToAction("CompleteProfile");
            }

            var viewModel = new SponsorProfileViewModel
            {
                Id = sponsor.Id,
                Name = sponsor.Name,
                Description = sponsor.Description,
                Website = sponsor.Website,
                UserEmail = currentUser.Email,
                UserFirstName = currentUser.FirstName,
                UserLastName = currentUser.LastName,
                ProfilePicturePath = currentUser.ProfilePicturePath
            };

            return View(viewModel);
        }

        // POST: Sponsor/UpdateProfile
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateProfile(SponsorProfileViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Profile", model);
            }

            var currentUser = await _userManager.GetUserAsync(User);
            if (currentUser == null)
            {
                return NotFound("User not found");
            }

            var sponsor = await _context.Sponsors
                .FirstOrDefaultAsync(s => s.UserId == currentUser.Id);

            if (sponsor == null)
            {
                return NotFound("Sponsor profile not found");
            }

            // Update sponsor information
            sponsor.Name = model.Name;
            sponsor.Description = model.Description;
            sponsor.Website = model.Website;

            _context.Update(sponsor);
            await _context.SaveChangesAsync();

            TempData["SuccessMessage"] = "Sponsor profile updated successfully";
            return RedirectToAction(nameof(Profile));
        }

        // GET: Sponsor/CompleteProfile
        public IActionResult CompleteProfile()
        {
            return View();
        }

        // POST: Sponsor/CompleteProfile
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CompleteProfile(SponsorProfileViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var currentUser = await _userManager.GetUserAsync(User);
            if (currentUser == null)
            {
                return NotFound("User not found");
            }

            // Check if profile already exists
            var existingSponsor = await _context.Sponsors
                .FirstOrDefaultAsync(s => s.UserId == currentUser.Id);

            if (existingSponsor != null)
            {
                // Just update and redirect to dashboard
                existingSponsor.Name = model.Name;
                existingSponsor.Description = model.Description;
                existingSponsor.Website = model.Website;

                _context.Update(existingSponsor);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Dashboard));
            }

            // Create new sponsor profile
            var sponsor = new Sponsor
            {
                Name = model.Name,
                Description = model.Description,
                Website = model.Website,
                UserId = currentUser.Id
            };

            _context.Sponsors.Add(sponsor);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Dashboard));
        }

        // POST: Sponsor/ExpressInterest/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ExpressInterest(int id)
        {
            var currentUser = await _userManager.GetUserAsync(User);
            if (currentUser == null)
            {
                return NotFound("User not found");
            }

            var sponsor = await _context.Sponsors
                .FirstOrDefaultAsync(s => s.UserId == currentUser.Id);

            if (sponsor == null)
            {
                return RedirectToAction("CompleteProfile");
            }

            var eventToSponsor = await _context.Events
                .FirstOrDefaultAsync(e => e.Id == id && e.Status == EventStatus.ApprovedForSponsorship);

            if (eventToSponsor == null)
            {
                return NotFound("Event not found or not available for sponsorship");
            }

            // Update event status and assign sponsor
            eventToSponsor.Status = EventStatus.SponsorshipDiscussion;
            eventToSponsor.SponsorId = sponsor.Id;

            _context.Update(eventToSponsor);
            await _context.SaveChangesAsync();

            TempData["SuccessMessage"] = "Interest expressed successfully. You can now start discussions with the organizer.";
            return RedirectToAction(nameof(EventDiscussions));
        }

        // POST: Sponsor/CancelInterest/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CancelInterest(int id)
        {
            var currentUser = await _userManager.GetUserAsync(User);
            if (currentUser == null)
            {
                return NotFound("User not found");
            }

            var sponsor = await _context.Sponsors
                .FirstOrDefaultAsync(s => s.UserId == currentUser.Id);

            if (sponsor == null)
            {
                return RedirectToAction("CompleteProfile");
            }

            var eventToCancel = await _context.Events
                .FirstOrDefaultAsync(e => e.Id == id && e.Status == EventStatus.SponsorshipDiscussion && e.SponsorId == sponsor.Id);

            if (eventToCancel == null)
            {
                return NotFound("Event not found or not in discussion with your organization");
            }

            // Revert event status and remove sponsor
            eventToCancel.Status = EventStatus.ApprovedForSponsorship;
            eventToCancel.SponsorId = null;

            _context.Update(eventToCancel);
            await _context.SaveChangesAsync();

            TempData["SuccessMessage"] = "Interest in event canceled successfully.";
            return RedirectToAction(nameof(EventsForSponsorship));
        }

        // POST: Sponsor/FinalizeSponsorship/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> FinalizeSponsorship(int id)
        {
            var currentUser = await _userManager.GetUserAsync(User);
            if (currentUser == null)
            {
                return NotFound("User not found");
            }

            var sponsor = await _context.Sponsors
                .FirstOrDefaultAsync(s => s.UserId == currentUser.Id);

            if (sponsor == null)
            {
                return RedirectToAction("CompleteProfile");
            }

            var eventToFinalize = await _context.Events
                .FirstOrDefaultAsync(e => e.Id == id && e.Status == EventStatus.SponsorshipDiscussion && e.SponsorId == sponsor.Id);

            if (eventToFinalize == null)
            {
                return NotFound("Event not found or not in discussion with your organization");
            }

            // Update event status to approved
            eventToFinalize.Status = EventStatus.Approved;

            _context.Update(eventToFinalize);
            await _context.SaveChangesAsync();

            TempData["SuccessMessage"] = "Sponsorship finalized successfully. The event is now approved and visible to the public.";
            return RedirectToAction(nameof(SponsoredEvents));
        }
    }
}