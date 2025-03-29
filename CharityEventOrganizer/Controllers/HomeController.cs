using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CharityEventOrganizer.Data;
using CharityEventOrganizer.Models.Entities;
using CharityEventOrganizer.Models.ViewModels;
using CharityEventOrganizer.Models;
using System.Diagnostics;

namespace CharityEventOrganizer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var featuredEvents = await _context.Events
                .Include(e => e.Cause)
                .Include(e => e.Organizer)
                .Where(e => e.Status == EventStatus.Approved)
                .OrderByDescending(e => e.CreatedDate)
                .Take(3)
                .ToListAsync();

            var causes = await _context.Causes.ToListAsync();

            var viewModel = new HomeViewModel
            {
                FeaturedEvents = featuredEvents,
                Causes = causes
            };

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}