using System.Collections.Generic;

namespace CharityEventOrganizer.Core.Entities
{
    public class Sponsor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string LogoUrl { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public string Website { get; set; }
        public bool IsActive { get; set; }

        // Navigation properties
        public virtual ICollection<EventSponsor> SponsoredEvents { get; set; }

        public Sponsor()
        {
            IsActive = true;
            SponsoredEvents = new HashSet<EventSponsor>();
        }
    }
}