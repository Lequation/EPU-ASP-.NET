using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EPUWeb
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
             "News",
             "tin/{seoName}-{id}-{p}",
             new { controller = "Category", action = "News", seoName = "" },
             new { id = @"^\d+$", p = @"^\d+$" }, new string[] { "EPUWeb.Controllers" }
            );

            routes.MapRoute(
             "Page",
             "p/{seoName}-{id}",
             new { controller = "Category", action = "Page", seoName = "" },
             new { id = @"^\d+$" }, new string[] { "EPUWeb.Controllers" }
            );

            routes.MapRoute(
             "Tag",
             "tag-tin/{seoName}-{p}",
             new { controller = "Category", action = "Tag", seoName = "" },
             new { p = @"^\d+$" }, new string[] { "EPUWeb.Controllers" }
            );

            routes.MapRoute(
             "DetailNews",
             "chi-tiet-tin/{seoName}-{id}",
             new { controller = "Single", action = "News", seoName = "" },
             new { id = @"^\d+$" }, new string[] { "EPUWeb.Controllers" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
