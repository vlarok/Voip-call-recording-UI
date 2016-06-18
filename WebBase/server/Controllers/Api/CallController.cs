using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.DTO;
using BLL.Services;
using Domain;
using Newtonsoft.Json;
using WebBase.server.ViewModel;

namespace WebBase.server.Controllers.Api
{
    public class CallController : ApiController
    {
        private CallService _service;

        public CallController(CallService service)
        {
            _service = service;
        }

        // GET: api/Call
        public List<CallDTO> GetCalls()
        {
            var allProducts = _service.getAllCalls();
            return allProducts;
        }

        // GET: api/Call/5
        public CallDTO GetCall(int id)
        {
           return _service.Find(id);

        }
        
        public RangeResponse Post(Range range)
        {
            //var ser = service;
            //  _repo.UdpateService(service);/*
            RangeResponse response = new RangeResponse()
            {
                Calls = _service.getCallsRange(range.From, range.To)
            };
           
            return response;
        }
        /*
            public HttpResponseMessage Post([FromBody]Range range)
        {
            //var ser = service;
            //  _repo.UdpateService(service);/*
            return Request.CreateResponse(HttpStatusCode.Created, _service.getCallsRange(range.From, range.To));

        }*/
        // PUT: api/Call/5
        public HttpResponseMessage Put(Call call)
        {
            //var ser = service;
            //  _repo.UdpateService(service);/*
            if (_service.AddOrUpdate(call))
            {
                return Request.CreateResponse(HttpStatusCode.OK, call);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotModified);
            }
        }


        // DELETE: api/Call/5
        public HttpResponseMessage Delete(int id)
        {
            if (_service.Delete(id))
            {
                return Request.CreateResponse(HttpStatusCode.OK, id);
            }
            return Request.CreateResponse(HttpStatusCode.NotModified);
        }
    }
}
