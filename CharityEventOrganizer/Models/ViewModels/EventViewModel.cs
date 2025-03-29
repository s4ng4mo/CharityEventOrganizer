using System;
using System.ComponentModel.DataAnnotations;
using CharityEventOrganizer.Models.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CharityEventOrganizer.Models.ViewModels
{
    public class EventViewModel
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
        [Display(Name = "Cause")]
        public int CauseId { get; set; }

        public SelectList CauseOptions { get; set; }

        public EventStatus Status { get; set; }
    }
}