using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using Domain;

namespace BLL.Factories
{
    public class UserFactory
    {
        public DTO.UserDTO createBasicDTO(User user)
        {


            return new DTO.UserDTO()
            {
                UserId = user.Id,
                UserName = user.UserName,
                PhoneNumber = user.PhoneNumber,
                Email=user.Email
                       };


        }
    }
}
