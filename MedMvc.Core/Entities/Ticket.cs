
using System.ComponentModel.DataAnnotations.Schema;

namespace MedMvc.Core.Entities
{
    public class Ticket : Entity
    {
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
        [ForeignKey("CampaignId")]
        public Campaign Campaign { get; set; }
        public TicketType Type { get; set; }
        public TicketStatus Status { get; set; }
    }
}
