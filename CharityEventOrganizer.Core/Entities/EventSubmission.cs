using System;

namespace CharityEventOrganizer.Core.Entities
{
    public enum SubmissionStatus
    {
        Pending,
        Approved,
        Rejected,
        SponsorReview,
        SponsorApproved
    }

    public class EventSubmission
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public string SubmitterId { get; set; }
        public DateTime SubmittedAt { get; set; }
        public SubmissionStatus Status { get; set; }
        public string RejectionReason { get; set; }
        public string AdminId { get; set; }
        public DateTime? ReviewedAt { get; set; }

        // Navigation properties
        public virtual Event Event { get; set; }
        public virtual ApplicationUser Submitter { get; set; }
        public virtual ApplicationUser Admin { get; set; }

        public EventSubmission()
        {
            SubmittedAt = DateTime.UtcNow;
            Status = SubmissionStatus.Pending;
        }
    }
}