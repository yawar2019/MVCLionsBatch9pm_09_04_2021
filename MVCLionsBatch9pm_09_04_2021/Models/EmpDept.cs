using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCLionsBatch9pm_09_04_2021.Models
{
    public class EmpDept
    {
        public List<EmployeeModel> emp { get; set; }
        public List<DepartmentModel> dept { get; set; }
    }
}