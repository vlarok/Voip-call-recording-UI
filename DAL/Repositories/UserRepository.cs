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
    public class UserRepository : IUserRepository
    {
        private ApplicationDbContext _ctx;

        public UserRepository(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public List<User> All
        {
            get
            {
                return _ctx.Users.ToList();
            }
        }

        public bool AddOrUpdate(User user)
        {
            try
            {

                _ctx.Users.AddOrUpdate(user);
                _ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {


                return false;
            }
        }

        /*
        public void Add(Call Call)
        {
            _ctx.Calls.Add(Call);
            _ctx.SaveChanges();
        }
        */
        public bool Delete(string id)
        {
            try
            {
                User user = (from s in All
                                   where s.Id == id
                                   select s).FirstOrDefault();
                _ctx.Users.Remove(user);
                _ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        //ei ole kindel kas pldse vaja
        public bool Add(User user)
        {
            try
            {
                var manager = new ApplicationUserManager(new UserStore<User>(_ctx));
               

                manager.Create(user, "!College83");
                _ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {


                return false;
            }
        }


    }
}
