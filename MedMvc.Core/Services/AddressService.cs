

using MedMvc.Core.Db;
using MedMvc.Core.Entities;

namespace MedMvc.Core.Services
{
    public class AddressService
    {
        private AppContext _db;

        public AddressService()
        {
            _db = new AppContext();
        }

        public void Add(Address address)
        {
            _db.Addresses.Add(address);
            _db.SaveChanges();
        }
    }
}
