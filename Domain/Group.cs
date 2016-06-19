using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Domain
{
    public class Group
    {

        public int GroupId { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime Created { get; set; }

        public virtual List<RoleGroup> RoleGroups { get; set; } = new List<RoleGroup>();

    }
}
