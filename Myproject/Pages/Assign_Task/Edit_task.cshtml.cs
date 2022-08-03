using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace Myproject.Pages.Assign_Task
{
    public class Edit_taskModel : PageModel
    {
        public EmployeesInfo employeesInfo = new EmployeesInfo();
        public String errormessage = "";
        public String successmessage = "";


        public void OnGet()
        {
            String empid = Request.Query["empid"];
           
            try
            {
                String connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=myproject;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "select * from assigntask where empid=@empid";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@empid", empid);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                employeesInfo.empid = "" + reader.GetInt32(0);
                                employeesInfo.emp_name = reader.GetString(1);
                                employeesInfo.emp_task = reader.GetString(3);

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                errormessage = ex.Message;
            }
        }
        public void OnPost()
        {
            employeesInfo.empid = Request.Form["empid"];
            employeesInfo.emp_name = Request.Form["emp_name"];
            employeesInfo.emp_task = Request.Form["emp_task"];

            if (employeesInfo.emp_name.Length == 0 || employeesInfo.emp_task.Length == 0)
               
            {
                errormessage = "All Fields Required";
                return;
            }

            try
            {
                String connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=myproject;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "update assigntask set emp_name=@emp_name, emp_task=@emp_task where empid=@empid";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@emp_name", employeesInfo.emp_name);
                        command.Parameters.AddWithValue("@emp_task", employeesInfo.emp_task);
                        command.Parameters.AddWithValue("@empid", employeesInfo.empid);

                        command.ExecuteNonQuery();

                        //successmessage = "New Employee Added Successully";
                    }
                }
            }
            catch (Exception ex)
            {
                errormessage = ex.Message;
                return;
            }

            Response.Redirect("/Assign_Task/task");
        }
    }
}
