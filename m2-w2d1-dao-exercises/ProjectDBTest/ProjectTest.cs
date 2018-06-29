using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlClient;
using System.Transactions;
using ProjectDB.DAL;
using ProjectDB.Models;
using System.Collections.Generic;

namespace ProjectDBTest
{
    [TestClass]
    public class ProjectTest
    {
        private TransactionScope scope;
        private string connectionString = @"Data Source=.\SQLexpress;Initial Catalog=Projects;Integrated Security=True";
        private string SQL_ProjectSelectLang = "SELECT COUNT(*) FROM project";
        private string SQL_InsertLang = "INSERT INTO project_employee (project_id, employee_id) VALUES (@projectId, @employeeId); ";

        private string SQL_AddEmployeeLang = "INSERT INTO employee " +
                "(department_id, first_name, last_name, job_title, birth_date, gender, hire_date) " +
                "VALUES (4, 'Test', 'Employee', 'Test Dummy', '1111-11-11', 'M', '1112-12-12');" +
                " SELECT CAST(SCOPE_IDENTITY() as int);";

        private string SQL_TopProjectLang = "SELECT TOP 1 project_id FROM project_employee  ORDER BY project_id DESC";
        private int projectCount = 0;
        private int employeeId = 0;
        private int projectId;

        [TestInitialize]//UNDONE
        public void Initialze()
        {
            scope = new TransactionScope();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd;
                connection.Open();

                cmd = new SqlCommand(SQL_ProjectSelectLang, connection);
                projectCount = (int)cmd.ExecuteScalar();

                cmd = new SqlCommand(SQL_AddEmployeeLang, connection);
                employeeId = (int)cmd.ExecuteScalar();

                cmd = new SqlCommand(SQL_TopProjectLang, connection);
                projectId = (int)cmd.ExecuteScalar();

                cmd = new SqlCommand(SQL_InsertLang, connection);
                cmd.Parameters.AddWithValue("@projectId",projectId);
                cmd.Parameters.AddWithValue("@employeeId", employeeId);
                cmd.ExecuteNonQuery();

            }
        }


        [TestCleanup]
        public void Cleanup()
        {
            scope.Dispose();
        }

        [TestMethod]
        public void GetAllProjects_Test()
        {
            ProjectSqlDAL projectTest = new ProjectSqlDAL(connectionString);
            List<Project> allProjects = projectTest.GetAllProjects();

            Assert.IsNotNull(allProjects);
            Assert.AreEqual(projectCount, allProjects.Count);
        }

        [TestMethod]
        public void AssignEmployeeToProject_Test()
        {

            ProjectSqlDAL projectTest = new ProjectSqlDAL(connectionString);

            bool didWork = projectTest.AssignEmployeeToProject(projectId, employeeId);

            Assert.IsTrue(didWork);
        }

        [TestMethod]
        public void RemoveEmployeeFromProject_Test()
        {
            ProjectSqlDAL projectTest = new ProjectSqlDAL(connectionString);

            bool didWork = projectTest.RemoveEmployeeFromProject(projectId, employeeId);

            Assert.IsTrue(didWork);
        }

        [TestMethod]
        public void CreateProject_Test()
        {

            ProjectSqlDAL projectTest = new ProjectSqlDAL(connectionString);
            Project testProject = new Project
            {
                Name = "testName",
                StartDate =  DateTime.Today,
                EndDate = DateTime.Now
            };


            bool didWork = projectTest.CreateProject(testProject);

            Assert.IsTrue(didWork);
        }
    }
}
