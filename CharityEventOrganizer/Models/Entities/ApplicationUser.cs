using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace CharityEventOrganizer.Models.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProfilePicturePath { get; set; }
        public ICollection<Event> OrganizedEvents { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
