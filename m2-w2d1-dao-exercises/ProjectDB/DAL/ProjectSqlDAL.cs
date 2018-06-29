using ProjectDB.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDB.DAL
{
    public class ProjectSqlDAL
    {
        private string connectionString;
        private const string SQL_Projects = "SELECT * FROM project";
        private const string SQL_InsertLanguage = @"INSERT INTO project VALUES (@Name, @StartDate, @EndDate)";
        private const string SQL_RemoveLanguage = "DELETE FROM project_employee WHERE project_id = @projectId AND employee_Id = @employeeId";
        private const string SQL_AddLanguage = "INSERT INTO project_employee (project_id, employee_id) VALUES (@projectId, @employeeId)";

        // Single Parameter Constructor
        public ProjectSqlDAL(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public List<Project> GetAllProjects()
        {
            List<Project> output = new List<Project>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(SQL_Projects, connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Project p = new Project();
                        p.Name = Convert.ToString(reader["name"]);
                        p.ProjectId = Convert.ToInt32(reader["project_id"]);
                        p.StartDate = Convert.ToDateTime(reader["from_date"]);
                        p.EndDate = Convert.ToDateTime(reader["to_date"]);

                        output.Add(p);
                    }
                }

            }
            catch (SqlException ex)
            {
                throw;
            }
            return output;
        }

        public bool AssignEmployeeToProject(int projectId, int employeeId)
        {
            bool result = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_AddLanguage, conn);

                    cmd.Parameters.AddWithValue("@projectId", projectId);
                    cmd.Parameters.AddWithValue("@employeeId", employeeId);

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

        public bool RemoveEmployeeFromProject(int projectId, int employeeId)
        {
            bool result = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_RemoveLanguage, conn);

                    cmd.Parameters.AddWithValue("@projectId", projectId);
                    cmd.Parameters.AddWithValue("@employeeId", employeeId);

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

        public bool CreateProject(Project newProject)
        {
            bool result = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(SQL_InsertLanguage, connection);
                    cmd.Parameters.AddWithValue("@Name", newProject.Name);
                    cmd.Parameters.AddWithValue("@StartDate", newProject.StartDate);
                    cmd.Parameters.AddWithValue("@EndDate", newProject.EndDate);

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
