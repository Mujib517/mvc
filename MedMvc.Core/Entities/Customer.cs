
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MedMvc.Core.Entities
{
    public class Customer : Entity
    {
        [Key]
        public string Phone { get; set; }
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public IEnumerable<Address> Address { get; set; }
        public IEnumerable<Ticket> Tickets { get; set; }
    }
}
