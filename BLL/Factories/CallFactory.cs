using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using Domain;

namespace BLL.Factories
{
    public class CallFactory
    {
        public DTO.CallDTO createBasicDTO(Call call)
        {


            return new DTO.CallDTO()
            {
               Anumber =call.Anumber,
Bnumber=call.Bnumber,
Dir = call.Dir,
Duration = call.Duration,
Created = call.Created,
AudioFileName = call.AudioFileName,
User = call.User.UserName,
Service = call.Service.Name,
Custom1 = call.Custom1
    };


        }
    }
}
