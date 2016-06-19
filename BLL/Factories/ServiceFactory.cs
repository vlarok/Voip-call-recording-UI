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
    public class ServiceFactory
    {
        public DTO.ServiceDTO createBasicDTO(Service service)
        {


            return new DTO.ServiceDTO()
            {
                ServiceId = service.ServiceId,
                Name = service.Name,
                Created = service.Created
            };


        }
    }
}
