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
    public class ServiceController : ApiController
    {
        private ServiceService _service;

        public ServiceController(ServiceService service)
        {
            _service = service;
        }

        // GET: api/Call
        public List<ServiceDTO> GetServices()
        {
            var allUsers = _service.GetAllServices();
            return allUsers;
        }


        public HttpResponseMessage Put(Service service)
        {
            service.Created = service.Created.ToLocalTime();
            //var ser = service;
            //  _repo.UdpateService(service);/*
            if (_service.AddOrUpdate(service))
            {
                return Request.CreateResponse(HttpStatusCode.OK, service);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotModified);
            }
        }


    }
}
