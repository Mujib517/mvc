
using MedMvc.Core.Db;
using MedMvc.Core.Entities;

namespace MedMvc.Core.Services
{
    public class TicketService
    {
        private AppContext _db;

        public TicketService()
        {
            _db = new AppContext();
        }

        public void Add(Ticket ticket)
        {
            _db.Tickets.Add(ticket);
            _db.SaveChanges();
        }
    }
}
