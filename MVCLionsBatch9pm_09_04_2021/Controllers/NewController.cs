using MVCLionsBatch9pm_09_04_2021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLionsBatch9pm_09_04_2021.Controllers
{
    public class NewController : Controller
    {
        // GET: shym got latest Code
        public ActionResult Index()
        {
            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Rajesh";
            emp.EmpSalary = 21000;

            ViewBag.info = emp;

            return View();
        }

        public string catchName()
        {
            string Name=Request.QueryString["Name"];
            return Name;
        }

        public ActionResult Index2()
        {
            List<EmployeeModel> listobj = new List<EmployeeModel>();
            


            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Rajesh";
            emp.EmpSalary = 21000;

            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "suresh";
            emp1.EmpSalary = 41000;

            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "Kamlesh";
            emp2.EmpSalary = 41000;

            listobj.Add(emp);
            listobj.Add(emp1);
            listobj.Add(emp2);


            ViewBag.info = listobj;
             

            return View();
        }

        public ActionResult Index3()
        {
           
            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Rajesh";
            emp.EmpSalary = 21000;
            //object model = emp;
            return View(emp);
        }

        public ActionResult Index4()
        {
            List<EmployeeModel> listobj = new List<EmployeeModel>();
            
            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Rajesh";
            emp.EmpSalary = 21000;

            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "suresh";
            emp1.EmpSalary = 41000;

            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "Kamlesh";
            emp2.EmpSalary = 41000;

            listobj.Add(emp);
            listobj.Add(emp1);
            listobj.Add(emp2);


            return View(listobj);
        }

        public ActionResult Index5()
        {
            List<EmployeeModel> listobj = new List<EmployeeModel>();
            List<DepartmentModel> listdept = new List<DepartmentModel>();

            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Rajesh";
            emp.EmpSalary = 21000;

            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "suresh";
            emp1.EmpSalary = 41000;

            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "Kamlesh";
            emp2.EmpSalary = 41000;

            listobj.Add(emp);
            listobj.Add(emp1);
            listobj.Add(emp2);


            DepartmentModel dept = new Models.DepartmentModel();
            dept.DeptId = 1;
            dept.DeptName = "IT";

            DepartmentModel dept1 = new Models.DepartmentModel();
            dept1.DeptId = 2;
            dept1.DeptName = "ECE";

            listdept.Add(dept);
            listdept.Add(dept1);

            EmpDept empdept = new Models.EmpDept();
            empdept.emp = listobj;
            empdept.dept = listdept;

            return View(empdept);
        }
        public ViewResult sendData()
        {
            ViewBag.Wish = "Want to become Immortal";
            return View("~/Views/Default/index.cshtml");
        }

        public ActionResult sendData3()
        {
            return Redirect("http://www.google.com");
        }


        public RedirectResult DisplayView()
        {
            return Redirect("http://www.google.com");
        }
        public RedirectResult DisplayView2()
        {
            return Redirect("~/new/Index5");
        }

        public ActionResult PartialViewExample()
        {
            return View();
        }

        public ActionResult PartialViewExample2()
        {
            List<EmployeeModel> listobj = new List<EmployeeModel>();

            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Rajesh";
            emp.EmpSalary = 21000;

            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "suresh";
            emp1.EmpSalary = 41000;

            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "Kamlesh";
            emp2.EmpSalary = 41000;

            listobj.Add(emp);
            listobj.Add(emp1);
            listobj.Add(emp2);


            return View(listobj);
        }
    }
}