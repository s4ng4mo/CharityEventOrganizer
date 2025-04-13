using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharityEventOrganizer.Models.Entities
{
    public class Message
    {
        public int Id { get; set; }

        [Required]
        public int EventId { get; set; }
        public Event Event { get; set; }

        [Required]
        public string SenderId { get; set; }

        [ForeignKey("SenderId")]
        public ApplicationUser Sender { get; set; }

        [Required]
        public string RecipientId { get; set; }

        [ForeignKey("RecipientId")]
        public ApplicationUser Recipient { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public DateTime SentAt { get; set; } = DateTime.Now;

        public bool IsRead { get; set; } = false;

        // This helps to determine if the message was sent by the sponsor or organizer
        [NotMapped]
        public bool IsFromSponsor { get; set; }
    }
}