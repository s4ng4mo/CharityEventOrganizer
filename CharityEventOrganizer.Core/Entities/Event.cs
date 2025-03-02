using System;
using System.Collections.Generic;

namespace CharityEventOrganizer.Core.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime EventDate { get; set; }
        public string Location { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? PublishedAt { get; set; }
        public bool IsPublished { get; set; }
        public string OrganizerId { get; set; }

        // Navigation properties
        public virtual ApplicationUser Organizer { get; set; }
        public virtual EventSubmission Submission { get; set; }
        public virtual ICollection<EventSponsor> EventSponsors { get; set; }

        public Event()
        {
            CreatedAt = DateTime.UtcNow;
            IsPublished = false;
            EventSponsors = new HashSet<EventSponsor>();
        }
    }
}