using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ThisIsFantasy
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
            "TeamSelection",                                              // Route name
            "{controller}/{action}/{id}/{leagueId}",                           // URL with parameters
            new { controller = "Home", action = "Index", artistName = "", apikey = "" }  // Parameter defaults
        );
        }
    }
}
