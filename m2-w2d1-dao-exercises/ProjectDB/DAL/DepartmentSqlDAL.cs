using ProjectDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjectDB.DAL
{
    public class DepartmentSqlDAL
    {
        private string connectionString;
        private const string SQL_Departments = "SELECT department_id, name FROM department";
        private const string SQL_InsertLanguage = "INSERT INTO department (name) VALUES (@Name)";
        private const string SQL_UpdatedLanguage = "UPDATE department SET name = @Name WHERE department_id = @id ";

        // Single Parameter Constructor
        public DepartmentSqlDAL(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public List<Department> GetDepartments()
        {
            List<Department> outputDepartments = new List<Department>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(SQL_Departments, connection);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Department d = new Department();
                        d.Name = Convert.ToString(reader["name"]);

                        outputDepartments.Add(d);
                    }
                }

            }
            catch (SqlException ex)
            {
                throw;
            }
            return outputDepartments;
        }

        public bool CreateDepartment(Department newDepartment)
        {
            bool result = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(SQL_InsertLanguage, connection);
                    cmd.Parameters.AddWithValue("@Name", newDepartment.Name);

                    int count = cmd.ExecuteNonQuery();

                    if (count == 1)
                    {
                        result = true;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return result;
        }

        public bool UpdateDepartment(Department updatedDepartment)
        {
            bool result = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(SQL_UpdatedLanguage, connection);
                    cmd.Parameters.AddWithValue("@Name", updatedDepartment.Name);
                    cmd.Parameters.AddWithValue("@id", updatedDepartment.Id);


                    int count = cmd.ExecuteNonQuery();
                    
                    if (count == 1)
                    {
                        result = true;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return result;
        }

    }
}
