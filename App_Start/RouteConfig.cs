using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Quanlybanvemaybay1
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
         name: "Register",
         url: "dang-ky",
         defaults: new { controller = "UserController", action = "Register", id = UrlParameter.Optional }
     );
            routes.MapRoute(
        name: "Login",
        url: "dang-nhap",
        defaults: new { controller = "UserController", action = "Login", id = UrlParameter.Optional }
    );
        }
    }
}
