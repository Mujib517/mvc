using MedMvc.Core.Entities;
using System;
using System.Collections.Generic;

namespace MedMvc.Core.Services
{
    public class UserService
    {
        public void Save(User user) { }

        public User GetById(string id) { return new User(); }

        public IEnumerable<User> Get() { throw new NotImplementedException(); }

        public void Delete(string id) { }

    }
}
