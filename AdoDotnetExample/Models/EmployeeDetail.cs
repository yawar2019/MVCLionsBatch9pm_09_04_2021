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
        SqlConnection con = new SqlConnection(@"Data Source=AZAM-PC\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=true;");

        public List<EmployeeDetail> getEmployee()
        {
            List<EmployeeDetail> listObj = new List<EmployeeDetail>();
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

        public int SaveEmployee(EmployeeDetail emp)
        {
            SqlCommand cmd = new SqlCommand("sp_CreateEmployee9pm", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmpName",emp.EmpName); 
            cmd.Parameters.AddWithValue("@EmpSalary",emp.EmpSalary);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }

       public EmployeeDetail getEmployeeById(int? id)
        {
            EmployeeDetail emp = new EmployeeDetail();
            SqlCommand cmd = new SqlCommand("sp_getNeerjaEmployeeDetailsById", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmpId", id);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                 
                emp.EmpId = Convert.ToInt32(dr[0]);
                emp.EmpName = Convert.ToString(dr[1]);
                emp.EmpSalary = Convert.ToInt32(dr[2]);
                 
            }
            return emp;
        }
    }
}