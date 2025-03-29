using System.Collections.Generic;
using CharityEventOrganizer.Models.Entities;

namespace CharityEventOrganizer.Models.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Event> FeaturedEvents { get; set; }
        public IEnumerable<Cause> Causes { get; set; }
    }
}