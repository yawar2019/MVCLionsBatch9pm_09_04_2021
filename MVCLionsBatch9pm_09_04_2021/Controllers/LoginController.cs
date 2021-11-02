using MVCLionsBatch9pm_09_04_2021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVCLionsBatch9pm_09_04_2021.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserDetail det)
        {
            EmployeeEntities db = new EmployeeEntities();
            var user = db.UserDetails.Where(s => s.UserName == det.UserName && s.Password == det.Password).SingleOrDefault();

            if (user != null)
            {
                FormsAuthentication.SetAuthCookie(det.UserName, false);
                return RedirectToAction("Dashboard");
            }
            return View();
        }

        [Authorize]
        public ActionResult Dashboard()
        {
            return View();
        }
    }
}