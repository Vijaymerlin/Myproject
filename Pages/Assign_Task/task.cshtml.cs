using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace Myproject.Pages.Assign_Task
{
    public class taskModel : PageModel
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
                    String sql = "select * from assigntask";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                EmployeesInfo employeesInfo = new EmployeesInfo();
                                employeesInfo.empid = "" + reader.GetInt32(0);
                                employeesInfo.emp_name = reader.GetString(1);
                                employeesInfo.emp_created_at = reader.GetDateTime(2).ToString();
                                employeesInfo.emp_task = reader.GetString(3);

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
        public string empid;
        public string emp_name;
        public string emp_created_at;
        public string emp_task;
    }
}
