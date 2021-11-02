using MVCLionsBatch9pm_09_04_2021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLionsBatch9pm_09_04_2021.MyCustomFilter
{
    //Action and ResultFilter
    public class UserDefinedFilter :ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
        }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
        }
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            (filterContext.Result as ViewResult).ViewBag.Player = "Chahal";
            EmployeeModel s=(EmployeeModel)(filterContext.Result as ViewResult).Model;
            s.EmpName = "Kanupriya";

        }
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
        }
    }
}