using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BasicMvcExample.Library
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "Bolgeler",
               url: "bolgeler",
               defaults: new { controller = "RoutingExample", action = "Bolgeler" }
           );
            routes.MapRoute(
               name: "Bolge",
               url: "bolgeler/{bolge}",
               defaults: new { controller = "RoutingExample", action = "Bolge", bolge = (string)null }
           );
            routes.MapRoute(
               name: "TupleExample",
               url: "tuple",
               defaults: new { controller = "Tuple", action = "TupleExample" }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            // routes.MapRoute(
            //    name: "Bolgeler",
            //    url: "bolgeler",
            //    defaults: new { controller = "RoutingExample", action = "Bolgeler" }
            //);
            // routes.MapRoute(
            //    name: "Bolge",
            //    url: "bolgeler/{bolge}",
            //    defaults: new { controller = "RoutingExample", action = "Bolge", bolge = (string)null }
            //);
        }
    }
}
