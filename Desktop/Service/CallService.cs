using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Domain;

namespace Desktop.Service
{
    class CallService:BaseService
    {

        public CallService() : base(ServiceConstants.PersonServiceUrl)
        {
        }
        public Task<HttpResponseMessage> addCall(Call newCall)
        {

             return this._client.PutAsJsonAsync<Call>("", newCall);
        }
    }
}
