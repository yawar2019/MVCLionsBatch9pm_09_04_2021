using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdoDotnetExample.Models;

namespace AdoDotnetExample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        EmployeeContext db = new EmployeeContext();
        public ActionResult Index()
        {
           
            return View(db.getEmployee());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeDetail emp)
        {
            int i = db.SaveEmployee(emp);
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            EmployeeDetail det = db.getEmployeeById(id);
            return View(det);
        }

        [HttpPost]
        public ActionResult Edit(EmployeeDetail emp)
        {
            int i = db.UpdateEmployee(emp);
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            EmployeeDetail det = db.getEmployeeById(id);
            return View(det);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            int i  = db.DeleteEmployeeById(id);
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}