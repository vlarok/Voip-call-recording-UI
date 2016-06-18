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
    public class UserController : ApiController
    {
        private UserService _service;

        public UserController(UserService service)
        {
            _service = service;
        }

        // GET: api/Call
        public List<UserDTO> GetUsers()
        {
            var allUsers = _service.getAllUsers();
            return allUsers;
        }

        public UserDTO GetUser(string id)
        {
           

            return _service.Find(id);

        }

        public HttpResponseMessage Put(User user)
        {
            //var ser = service;
            //  _repo.UdpateService(service);/*
            if (_service.AddOrUpdate(user))
            {
                return Request.CreateResponse(HttpStatusCode.OK, user);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotModified);
            }
        }


    }
}
