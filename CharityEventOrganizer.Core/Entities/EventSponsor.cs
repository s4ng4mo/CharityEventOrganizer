using System;

namespace CharityEventOrganizer.Core.Entities
{
    public enum SponsorshipStatus
    {
        Pending,
        Approved,
        Rejected
    }

    public class EventSponsor
    {
        public int EventId { get; set; }
        public int SponsorId { get; set; }
        public DateTime RequestedAt { get; set; }
        public DateTime? ResponseAt { get; set; }
        public SponsorshipStatus Status { get; set; }
        public string Notes { get; set; }

        // Navigation properties
        public virtual Event Event { get; set; }
        public virtual Sponsor Sponsor { get; set; }

        public EventSponsor()
        {
            RequestedAt = DateTime.UtcNow;
            Status = SponsorshipStatus.Pending;
        }
    }
}