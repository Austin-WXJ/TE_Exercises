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
        private const string SQL_SearchLanguage = "SELECT * FROM employee WHERE first_name = @firstName AND last_name = @lastName";//UNDONE
        private const string SQL_WOprojectLanguage = "SELECT e.*  FROM employee e LEFT JOIN project_employee pe ON pe.employee_id = e.employee_id WHERE pe.project_id IS NULL";//UNDONE

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

        public List<Employee> Search(string firstName, string lastName)
        {
            List<Employee> output = new List<Employee>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(SQL_SearchLanguage, connection);
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Employee e = new Employee();

                        e.EmployeeId = Convert.ToInt32(reader["employee_id"]);
                        e.DepartmentId = Convert.ToInt32(reader["department_id"]);
                        e.JobTitle = Convert.ToString(reader["job_title"]);
                        e.FirstName = Convert.ToString(reader["first_name"]);
                        e.LastName = Convert.ToString(reader["last_name"]);
                        e.BirthDate = Convert.ToDateTime(reader["Birth_Date"]);
                        e.Gender = Convert.ToString(reader["gender"]);
                        e.BirthDate = Convert.ToDateTime(reader["Birth_Date"]);
                        e.HireDate = Convert.ToDateTime(reader["hire_date"]);

                        output.Add(e);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return output;
        }

        public List<Employee> GetEmployeesWithoutProjects()//UNDONE
        {
            List<Employee> output = new List<Employee>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(SQL_WOprojectLanguage, connection);
                    cmd.ExecuteNonQuery();

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Employee e = new Employee();

                        e.EmployeeId = Convert.ToInt32(reader["employee_id"]);
                        e.DepartmentId = Convert.ToInt32(reader["department_id"]);
                        e.JobTitle = Convert.ToString(reader["job_title"]);
                        e.FirstName = Convert.ToString(reader["first_name"]);
                        e.LastName = Convert.ToString(reader["last_name"]);
                        e.BirthDate = Convert.ToDateTime(reader["Birth_Date"]);
                        e.Gender = Convert.ToString(reader["gender"]);
                        e.BirthDate = Convert.ToDateTime(reader["Birth_Date"]);
                        e.HireDate = Convert.ToDateTime(reader["hire_date"]);

                        output.Add(e);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return output;
        }
    }
}
