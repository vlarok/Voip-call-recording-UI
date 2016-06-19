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
    public class GroupController : ApiController
    {
        private GroupService _service;

        public GroupController(GroupService service)
        {
            _service = service;
        }

        // GET: api/Call
        public List<GroupDTO> GetServices()
        {
            var allGroups = _service.GetAllGroups();
            return allGroups;
        }


        public HttpResponseMessage Put(Group group)
        {
            group.Created = group.Created.ToLocalTime();
            //var ser = service;
            //  _repo.UdpateService(service);/*
            if (_service.AddOrUpdate(group))
            {
                return Request.CreateResponse(HttpStatusCode.OK, group);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotModified);
            }
        }


    }
}
