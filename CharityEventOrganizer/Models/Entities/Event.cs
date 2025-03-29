using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharityEventOrganizer.Models.Entities
{
    public class Event
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Event Date")]
        [DataType(DataType.Date)]
        public DateTime EventDate { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public EventStatus Status { get; set; }

        [Required]
        public int CauseId { get; set; }
        public Cause Cause { get; set; }

        [Required]
        public string OrganizerId { get; set; }

        [ForeignKey("OrganizerId")]
        public ApplicationUser Organizer { get; set; }

        public int? SponsorId { get; set; }
        public Sponsor Sponsor { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public ICollection<Comment> Comments { get; set; }
    }

    public enum EventStatus
    {
        Submitted,
        UnderReview,
        ApprovedForSponsorship,
        SponsorshipDiscussion,
        Approved,
        Rejected
    }
}
