using System.Collections.Generic;
using CharityEventOrganizer.Models.Entities;

namespace CharityEventOrganizer.Models.ViewModels
{
    public class EventConversationViewModel
    {
        public Event Event { get; set; }
        public IEnumerable<Message> Messages { get; set; }
        public string OtherPartyName { get; set; }
        public string OtherPartyInitial { get; set; }
        public bool IsOrganizer { get; set; }
    }
}