using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Domain
{
    public class Role : IdentityRole
    {

        public Role() : base() { }
        public Role(string name)
            : base(name)
        {
           
        }
        public virtual string[] Roles { get; set; }


        public virtual List<RoleGroup> RoleGroups { get; set; } = new List<RoleGroup>();

    }
}
