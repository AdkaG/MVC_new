using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Laboration_1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "Volvo",
               url: "Company/{action}/{carModel}",
               defaults: new { controller = "Company", action = "Volvo", carModel = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "LifeDefault",
               url: "Life/{action}/{id}",
               defaults: new { controller = "Life", action = "SuperMario", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "LaserDefault",
               url: "Laser/{action}/{id}",
               defaults: new { controller = "Laser", action = "Sabel", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "Selling",
               url: "Sell/{action}/{id}",
               defaults: new { controller = "Sell", action = "B2B", id = UrlParameter.Optional }
           );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
