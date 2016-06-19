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
    public class GroupRepository : IGroupRepository
    {
        private ApplicationDbContext _ctx;

        public GroupRepository(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public List<Group> All
        {
            get
            {
                return _ctx.Groups.ToList();
            }
        }

        public bool AddOrUpdate(Group group)
        {
            try
            {
                ///eemaladada kõik RoleGroup suhted ja lisada uuesti
               
                _ctx.Groups.AddOrUpdate(group);
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
                Group group= (from s in All
                                   where s.GroupId == id
                                   select s).FirstOrDefault();
                _ctx.Groups.Remove(group);
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
