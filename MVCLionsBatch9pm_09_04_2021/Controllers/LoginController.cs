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
                Session["UserName"] = user.UserName;
                FormsAuthentication.SetAuthCookie(det.UserName, false);//Auth=asdfaasdfxfsdfsd
                return RedirectToAction("Dashboard");
            }
            return View();
        }

        [Authorize]
        public ActionResult Dashboard()
        {
            return View();
        }

        [Authorize(Roles="Admin")]
        public ActionResult Contact()
        {
            return View();
        }

        [Authorize(Roles = "Manager")]
        public ActionResult AboutUs()
        {
            return View();
        }
        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return Redirect("~/login/login");
        }
    }
}