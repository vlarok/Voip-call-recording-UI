using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.DTO;
using BLL.Services;
using Domain;

namespace WebBase.server.Controllers.Api
{
    public class RoleController : ApiController
    {
        private RoleService _service;

        public RoleController(RoleService service)
        {
            _service = service;
        }

        // GET: api/Call
        public List<RoleDTO> GetRoles()
        {
            var allGroups = _service.GetAllRoles();
            return allGroups;
        }


    }
}
