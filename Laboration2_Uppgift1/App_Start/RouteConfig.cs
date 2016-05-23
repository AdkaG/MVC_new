using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Laboration2_Uppgift1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "TwentyOne",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "TwentyOne", action = "TwentyOne", id = UrlParameter.Optional }
            );
        }
    }
}
