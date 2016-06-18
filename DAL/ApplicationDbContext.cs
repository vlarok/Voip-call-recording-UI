using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DAL
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        public System.Data.Entity.DbSet<Call> Calls { get; set; }
        public System.Data.Entity.DbSet<Comment> Comments { get; set; }
        public System.Data.Entity.DbSet<Service> Services { get; set; }
    }
}
