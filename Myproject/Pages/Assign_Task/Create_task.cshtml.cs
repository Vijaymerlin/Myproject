using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace Myproject.Pages.Assign_Task
{
    public class Create_taskModel : PageModel
    {
        public EmployeesInfo employeesInfo = new EmployeesInfo();
        public String errormessage = "";
        public String successmessage = "";
        public void OnGet()
        {
        }
        public void OnPost()
        {
            employeesInfo.emp_name = Request.Form["emp_name"];
            employeesInfo.emp_task = Request.Form["emp_task"];

            if (employeesInfo.emp_name.Length == 0 || employeesInfo.emp_task.Length == 0 )
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
                    String sql = "insert into assigntask (emp_name, emp_task)values(@emp_name, @emp_task)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@emp_name", employeesInfo.emp_name);
                        command.Parameters.AddWithValue("@emp_task", employeesInfo.emp_task);

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

            employeesInfo.emp_name = "";
            employeesInfo.emp_task = "";

            successmessage = "New Employee Added Successully";

            Response.Redirect("/Assign_Task/task");

        }
    }
}
