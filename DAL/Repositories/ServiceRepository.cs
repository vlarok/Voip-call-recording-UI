using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using Domain;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DAL.Repositories
{
    public class ServiceRepository : IServiceRepository
    {
        private ApplicationDbContext _ctx;

        public ServiceRepository(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public List<Service> All
        {
            get
            {
                return _ctx.Services.ToList();
            }
        }

        public bool AddOrUpdate(Service service)
        {
            try
            {

                _ctx.Services.AddOrUpdate(service);
                _ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {


                return false;
            }
        }


        public bool Delete(int id)
        {
            try
            {
                Service service= (from s in All
                                   where s.ServiceId == id
                                   select s).FirstOrDefault();
                _ctx.Services.Remove(service);
                _ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
      

    }
}
