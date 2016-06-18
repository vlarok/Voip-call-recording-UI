using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Service
{
    public class BaseService
    {
        public HttpClient _client;

        public BaseService(string serviceurl)
        {
            this._client = new HttpClient();
            this._client.BaseAddress = new Uri(serviceurl);
        }

       
    }
}
