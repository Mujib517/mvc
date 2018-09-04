using MedMvc.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MedMvc.Core.Services
{
    public class UserService
    {
        private Db.AppContext _db;

        public UserService()
        {
            _db = new Db.AppContext();
        }

        public void Save(User user)
        {
            _db.Users.Add(user);
            _db.SaveChanges();
        }
        public User GetById(string id)
        {
            return _db.Users.FirstOrDefault(u => u.Username == id);
        }

        public IEnumerable<User> Get()
        {
            return _db.Users.ToList();
        }

        public void Delete(string id)
        {
            var user = _db.Users.FirstOrDefault(u => u.Username == id);
            _db.Users.Remove(user);
            _db.SaveChanges();
        }

    }
}
