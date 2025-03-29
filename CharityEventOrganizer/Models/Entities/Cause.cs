using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CharityEventOrganizer.Models.Entities
{
    public class Cause
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public ICollection<Event> Events { get; set; }
    }
}
