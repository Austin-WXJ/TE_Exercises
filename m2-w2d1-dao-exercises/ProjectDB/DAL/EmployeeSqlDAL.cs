using ProjectDB.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDB.DAL
{
    public class EmployeeSqlDAL
    {
        private string connectionString;
        private const string SQL_EmployeeList = "SELECT * FROM employee";

        // Single Parameter Constructor
        public EmployeeSqlDAL(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> output = new List<Employee>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(SQL_EmployeeList, connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Employee emp = new Employee();
                        emp.EmployeeId = Convert.ToInt32(reader["employee_id"]);
                        emp.DepartmentId = Convert.ToInt32(reader["department_id"]);
                        emp.JobTitle = Convert.ToString(reader["job_title"]);
                        emp.FirstName = Convert.ToString(reader["first_name"]);
                        emp.LastName = Convert.ToString(reader["last_name"]);
                        emp.BirthDate = Convert.ToDateTime(reader["Birth_Date"]);
                        emp.Gender = Convert.ToString(reader["gender"]);
                        emp.BirthDate = Convert.ToDateTime(reader["Birth_Date"]);
                        emp.HireDate = Convert.ToDateTime(reader["hire_date"]);

                        output.Add(emp);
                    }
                }

            }
            catch (SqlException ex)
            {
                throw;
            }
            return output;
        }

        public List<Employee> Search(string firstname, string lastname)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetEmployeesWithoutProjects()
        {
            throw new NotImplementedException();
        }
    }
}
