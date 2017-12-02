using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace JL.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "SkinCarePage",
                url: "skincare/page-{page}",
                defaults: new { controller = "skincare", action = "page" },
                constraints: new { page = @"\d+" },
                namespaces: new string[] { "JL.Web.Controllers" }
            );
            // productcenter
            routes.MapRoute(
                name: "productcenter",
                url: "product/{id}",
                defaults: new { controller = "product", action = "index" },
                constraints: new { id = @"\d+" },
                namespaces: new string[] { "JL.Web.Controllers" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "JL.Web.Controllers" }
            );
            
        }
    }
}
