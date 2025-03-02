using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace CharityEventOrganizer.Core.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProfilePictureUrl { get; set; }

        // Navigation properties
        public virtual ICollection<EventSubmission> EventSubmissions { get; set; }

        public ApplicationUser()
        {
            EventSubmissions = new HashSet<EventSubmission>();
        }
    }
}