using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace Myproject.Pages.Employees
{
    public class EditModel : PageModel
    {
        public EmployeesInfo employeesInfo = new EmployeesInfo();
        public String errormessage = "";
        public String successmessage = "";
        public void OnGet()
        {
            String id = Request.Query["id"];
            try
            {
                String connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=myproject;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "select * from employees where id=@id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                
                                employeesInfo.id = "" + reader.GetInt32(0);
                                employeesInfo.name = reader.GetString(1);
                                employeesInfo.email = reader.GetString(2);
                                employeesInfo.phone = reader.GetString(3);
                                employeesInfo.address = reader.GetString(4);
                                //employeesInfo.task = reader.GetString(5);

                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                errormessage = ex.Message;
            }
        }
        public void OnPost()
        {
            employeesInfo.id = Request.Form["id"];
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
                    String sql = "update employees set name=@name, email=@email, phone= @phone, address=@address, task=@task where id=@id";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@name", employeesInfo.name);
                        command.Parameters.AddWithValue("@email", employeesInfo.email);
                        command.Parameters.AddWithValue("@phone", employeesInfo.phone);
                        command.Parameters.AddWithValue("@address", employeesInfo.address);
                        command.Parameters.AddWithValue("@task", employeesInfo.task);
                        command.Parameters.AddWithValue("@id", employeesInfo.id);

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

            Response.Redirect("/Employees/Index");
        }
    }
}
