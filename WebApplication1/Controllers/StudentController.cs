using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using System.Data.OleDb;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult Students()
        {
            //String connectionString = "Provider=MSOLEDBSQL;Data Source=192.168.100.56;Initial Catalog=LSG_TIMESHEET;Persist Security Info=True;User ID=Timesheet;Password=tsheet@1$;Pooling=False;providerName=System.Data.OleDb";
            String connectionString = "Data Source=192.168.100.56;Initial Catalog=LSG_TIMESHEET;Persist Security Info=True;User ID=Timesheet;Password=tsheet@1$";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            String sql = "SELECT Top 10 * FROM Master_Employee where EMPLOYEEACTIVE=1 and EXEMPT='E' and SUB_DIVISION='LSG'";
            SqlCommand cmd = new SqlCommand(sql, conn);            

            var model = new List<Student>();
            //using (SqlConnection conn = new SqlConnection(connectionString))
            //{
              //  conn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                var student = new Student();
                student.Employee_No = rdr["Employee_Number"].ToString();
                student.FirstName = rdr["Employee_First"].ToString();
                student.LastName = rdr["Employee_Name"].ToString();
 
                model.Add(student);
            }
            //}
            return View(model);
        }
    }
}