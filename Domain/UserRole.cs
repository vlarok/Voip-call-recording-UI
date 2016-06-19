using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Domain
{
    public class UserRole : IdentityUserRole
    {
        public bool YesNo  { get; set; }
    }
}
