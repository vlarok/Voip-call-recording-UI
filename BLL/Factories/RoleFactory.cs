using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using Domain;

namespace BLL.Factories
{
    public class RoleFactory
    {
        public DTO.RoleDTO createBasicDTO(Role role)
        {


            return new DTO.RoleDTO()
            {
                RoleId = role.Id,
                Name = role.Name

            };


        }
    }
}
