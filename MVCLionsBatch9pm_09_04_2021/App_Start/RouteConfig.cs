using MVCLionsBatch9pm_09_04_2021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCLionsBatch9pm_09_04_2021
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Default1",
                url: "New/index/{id}",
                defaults: new { controller = "New", action = "Index2", id = UrlParameter.Optional },
                constraints:new {id=@"\d{1,3}"}
            );

            routes.MapRoute(
                name: "Default2",
                url: "New/Employeeinfo/{EmailId}",
                defaults: new { controller = "New", action = "CheckEmail", id = UrlParameter.Optional },
                constraints: new { EmailId = new Emailconstraint() }
            );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


        }
    }
}
