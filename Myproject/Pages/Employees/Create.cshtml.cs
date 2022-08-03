using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace Myproject.Pages.Employees
{
    public class CreateModel : PageModel
    {
        public EmployeesInfo employeesInfo = new EmployeesInfo();
        public String errormessage = "";
        public String successmessage = "";
        public void OnGet()
        {
        }
        public void OnPost()
        {
            employeesInfo.name = Request.Form["name"];
            employeesInfo.email = Request.Form["email"];
            employeesInfo.phone = Request.Form["phone"];
            employeesInfo.address = Request.Form["address"];
            employeesInfo.task = Request.Form["task"];

            if (employeesInfo.name.Length == 0 || employeesInfo.email.Length == 0 ||
               employeesInfo.phone.Length == 0 || employeesInfo.address.Length == 0)
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
                    String sql = "insert into employees (name, email, phone, address, task)values(@name, @email, @phone, @address, @task)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@name", employeesInfo.name);
                        command.Parameters.AddWithValue("@email", employeesInfo.email);
                        command.Parameters.AddWithValue("@phone", employeesInfo.phone);
                        command.Parameters.AddWithValue("@address", employeesInfo.address);
                        command.Parameters.AddWithValue("@task", employeesInfo.task);

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

            employeesInfo.name = "";
            employeesInfo.email = "";
            employeesInfo.phone = "";
            employeesInfo.address = "";
            employeesInfo.task = "";

            successmessage = "New Employee Added Successully";

            Response.Redirect("/Employees/Index");

        }
    }
}
