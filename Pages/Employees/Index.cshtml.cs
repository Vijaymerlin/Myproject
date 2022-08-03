using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace Myproject.Pages.Employees
{
    public class IndexModel : PageModel
    {
        public List<EmployeesInfo> listEmployees = new List<EmployeesInfo>();
        public void OnGet()
        {
            try
            {
                String connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=myproject;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "select * from employees";
                    using(SqlCommand command= new SqlCommand(sql, connection))
                    {
                       using(SqlDataReader reader = command.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                EmployeesInfo employeesInfo = new EmployeesInfo();
                                employeesInfo.id = "" + reader.GetInt32(0);
                                employeesInfo.name = reader.GetString(1);
                                employeesInfo.email = reader.GetString(2);
                                employeesInfo.phone = reader.GetString(3);
                                employeesInfo.address = reader.GetString(4);
                                employeesInfo.created_at = reader.GetDateTime(5).ToString();
                                employeesInfo.task = "";

                                listEmployees.Add(employeesInfo);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:" + ex.ToString());
            }
        }
    }
    public class EmployeesInfo
    {
        public string id;
        public string name;
        public string email;
        public string phone;
        public string address;
        public string created_at;
        public string task;
    }
}
