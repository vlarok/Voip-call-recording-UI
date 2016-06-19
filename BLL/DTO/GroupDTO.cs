using System;
using System.Collections.Generic;

namespace BLL.DTO
{
    public class GroupDTO
    {
        public int GroupId { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public virtual List<RoleDTO> Roles { get; set; } = new List<RoleDTO>();

    }
}
