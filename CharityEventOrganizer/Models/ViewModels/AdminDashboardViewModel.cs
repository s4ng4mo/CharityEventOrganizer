using System.Collections.Generic;
using CharityEventOrganizer.Models.Entities;

namespace CharityEventOrganizer.Models.ViewModels
{
    public class AdminDashboardViewModel
    {
        public int EventsPendingReview { get; set; }
        public int TotalUsers { get; set; }
        public int TotalSponsors { get; set; }
        public int TotalApprovedEvents { get; set; }
        public IEnumerable<Event> RecentEvents { get; set; }
        public bool HasPendingPersonalEvents { get; set; }
    }
}