using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebBase
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {/*
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                 "Default",
                "{*url}",
                  new { controller = "Home", action = "Index" }
             );*/
            routes.MapPageRoute("Default", "{*anything}", "~/public/index.html");
        }
    }
}
