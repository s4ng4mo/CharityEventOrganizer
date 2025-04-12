using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CharityEventOrganizer.Models.Entities;

namespace CharityEventOrganizer.Models.ViewModels
{
    public class SponsorViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Website { get; set; }
        public ApplicationUser User { get; set; }
        public IEnumerable<Event> SponsoredEvents { get; set; }
    }

    public class SponsorDashboardViewModel
    {
        public Sponsor Sponsor { get; set; }
        public IEnumerable<Event> EventsNeedingSponsors { get; set; }
        public IEnumerable<Event> EventsInDiscussion { get; set; }
        public IEnumerable<Event> SponsoredEvents { get; set; }
    }

    public class SponsorEventsViewModel
    {
        public IEnumerable<Event> Events { get; set; }
        public IEnumerable<Cause> Causes { get; set; }
        public int? CurrentCauseId { get; set; }
        public string SearchTerm { get; set; }
        public string SortBy { get; set; }
    }

    public class SponsorProfileViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters")]
        public string Name { get; set; }

        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters")]
        public string Description { get; set; }

        [Url(ErrorMessage = "Please enter a valid website URL")]
        [StringLength(200, ErrorMessage = "Website URL cannot exceed 200 characters")]
        public string Website { get; set; }

        // User related info (not editable directly here)
        public string UserEmail { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        // Removed ProfilePicturePath property
    }
}