using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using Desktop.Service;
using Domain;

namespace Desktop.ViewModels
{
    public class MainWindowVM 
    {
        private CallService _callService;


        public MainWindowVM()
        {
            _callService = new CallService();
        }

       
        public Task<HttpResponseMessage> addCall(Call newCall)
        {
            return _callService.addCall(newCall);
        }

       
    }
}
