using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.DTO;
using BLL.Services;
using Domain;

namespace WebBase.server.Controllers.Api
{
    public class CommentController : ApiController
    {
        private CommentService _service;

        public CommentController(CommentService service)
        {
            _service = service;
        }



  
        public HttpResponseMessage Put(Comment comment)
        {
            if (_service.AddOrUpdate(comment))
            {
                return Request.CreateResponse(HttpStatusCode.OK, comment);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotModified);
            }
        }


       
    }
}
