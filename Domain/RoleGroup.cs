using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class RoleGroup
    {
        public int RoleGroupId { get; set; }
        public string RoleId { get; set; }
        public virtual Role Role { get; set; }
        public int GroupId { get; set; }
        public virtual Group Group { get; set; }
    }
}
