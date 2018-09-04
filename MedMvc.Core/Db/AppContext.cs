using MedMvc.Core.Entities;
using System.Data.Entity;

namespace MedMvc.Core.Db
{
    public class AppContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}
