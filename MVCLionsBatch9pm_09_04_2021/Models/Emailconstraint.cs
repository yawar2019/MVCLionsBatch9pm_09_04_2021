using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace MVCLionsBatch9pm_09_04_2021.Models
{
    public class Emailconstraint : IRouteConstraint
    {
        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            string EmailId = values["EmailId"].ToString();
            if (EmailId.Contains("@"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}