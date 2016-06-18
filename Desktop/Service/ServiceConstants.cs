using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Service
{
    public static class ServiceConstants
    {
        private static string getValue(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        public static string PersonServiceUrl
        {
            get { return getValue("PersonServiceUrl"); }
        }
    }
}
