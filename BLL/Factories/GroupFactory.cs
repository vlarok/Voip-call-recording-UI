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
    public class GroupFactory
    {
        public DTO.GroupDTO createBasicDTO(Group group)
        {


            return new DTO.GroupDTO()
            {
                GroupId = group.GroupId,
                Name = group.Name,
                Created = group.Created,
                Roles = group.RoleGroups.Select(s=>new RoleDTO() {RoleId = s.RoleId,Name = s.Role.Name}).ToList()
                // Bids = product.Bids.Select(s => new BidDTO() { UserName = s.User.UserName, BidValue = s.BidValue }).ToList()

            };


        }
    }
}
