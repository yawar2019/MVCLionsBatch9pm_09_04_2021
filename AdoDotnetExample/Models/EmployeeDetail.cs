using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AdoDotnetExample.Models
{
    public class EmployeeDetail
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpSalary { get; set; }
    }

    class EmployeeContext
    {
        public List<EmployeeDetail> getEmployee()
        {
            List<EmployeeDetail> listObj = new List<EmployeeDetail>();
            SqlConnection con = new SqlConnection(@"Data Source=AZAM-PC\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=true;");
            SqlCommand cmd = new SqlCommand("usp_getEmployeeDetail9pm", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                EmployeeDetail emp = new EmployeeDetail();
                emp.EmpId = Convert.ToInt32(dr[0]);
                emp.EmpName = Convert.ToString(dr[1]);
                emp.EmpSalary = Convert.ToInt32(dr[2]);
                listObj.Add(emp);
            }
            return listObj;
        }

    }
}