using MedMvc.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MedMvc.Core.Services
{
    public class Campaign_Serv
    {

        private Db.AppContext _db;
        public Campaign_Serv()
        {
            _db = new Db.AppContext();
        }

        public void Save(Campaign campaign)
        {
            _db.Campaigns.Add(campaign);
            _db.SaveChanges();
        }

        public Campaign GetById(int id)
        {
            return _db.Campaigns.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Campaign> Get()
        {
            return _db.Campaigns.ToList();
        }

        public void Delete(int id)
        {
            var user = _db.Campaigns.FirstOrDefault(c => c.Id == id);
            _db.Campaigns.Remove(user);
            _db.SaveChanges();
        }

    }
}
