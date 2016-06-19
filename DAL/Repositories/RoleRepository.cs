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
    public class RoleRepository : IRoleRepository
    {
        private ApplicationDbContext _ctx;

        public RoleRepository(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public List<Role> All
        {
            get
            {
                return _ctx.Roles.ToList();
            }
        }

    }
}
