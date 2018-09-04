

using MedMvc.Core.Db;
using MedMvc.Core.Entities;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MedMvc.Core.Services
{
    public class CustomerService
    {
        public AppContext _db;
        public CustomerService()
        {
            _db = new AppContext();
        }

        public IEnumerable<Customer> Get()
        {
            return _db.Customers.ToList();
        }

        public Customer GetById(string phone)
        {
            return _db.Customers.FirstOrDefault(c => c.Phone == phone);
        }

        public void Add(Customer customer)
        {
            _db.Customers.Add(customer);
            _db.SaveChanges();
        }

        public void Delete(string phone)
        {
            var customer = _db.Customers.FirstOrDefault(c => c.Phone == phone);
            if (customer == null) return;

            _db.Customers.Remove(customer);
            _db.SaveChanges();
        }
    }
}
