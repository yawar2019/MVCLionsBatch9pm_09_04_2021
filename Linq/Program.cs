﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{

    public class EmployeeModel
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpSalary { get; set; }
        public int DeptId { get; set; }
        public List<DepartmentModel> dept { get; set; }
    }

    public class DepartmentModel
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        
    }
    class Program
    {

        static void Main(string[] args)
        {
            //int[] arr = { 1, 2, 3, 9, 20, 26 };
            string[] arr = { "India", "China", "Japan" };
            List<string> listemp = new List<string> {"James","Richard"};
            //var result = from s in arr
            //             where s.StartsWith("I")
            //             select s;
            //var result = listemp.Where(s=>s.Contains("i"));

            List<DepartmentModel> listdeptobj = new List<DepartmentModel>();

            DepartmentModel dept = new DepartmentModel();


            EmployeeModel dept1 = new EmployeeModel();
            dept.DeptId = 2;

            List<EmployeeModel> listobj = new List<EmployeeModel>();

            EmployeeModel emp = new EmployeeModel();
            emp1.DeptId = 1;

            EmployeeModel emp2 = new EmployeeModel();
            
            var result = listobj.Where(s => s.EmpId > 1).ToList();

            foreach (var item in result)
            {
                Console.WriteLine("{0}-{1}-{2}",item.EmpId,item.EmpName,item.EmpSalary);
            }
            Console.ReadLine();
        }
    }
}