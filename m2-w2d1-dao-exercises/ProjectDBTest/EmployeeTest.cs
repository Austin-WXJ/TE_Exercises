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
    public class EmployeeTest
    {
        private TransactionScope scope;
        private string connectionString = @"Data Source=.\SQLexpress;Initial Catalog=Projects;Integrated Security=True";
        private int employeeCount = 0;
        private int employeeCode = 0;
        private int noProjectsCount = 0;

        [TestInitialize]//UNDONE
        public void Initialze()
        {
            scope = new TransactionScope();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd;
                connection.Open();
                cmd = new SqlCommand("SELECT COUNT(*) FROM employee", connection);
                employeeCount = (int)cmd.ExecuteScalar();

                cmd = new SqlCommand(
                    "INSERT INTO employee " +
                    "(department_id, first_name, last_name, job_title, birth_date, gender, hire_date) " +
                    "VALUES (4, 'Test', 'Employee', 'Test Dummy', '1111-11-11', 'M', '1112-12-12');" +
                    " SELECT CAST(SCOPE_IDENTITY() as int);",
                    connection);
                employeeCode = (int)cmd.ExecuteScalar();

                cmd = new SqlCommand(
                    "SELECT COUNT(*) " +
                    "FROM employee e " +
                    "LEFT JOIN project_employee pe ON pe.employee_id = e.employee_id " +
                    "WHERE pe.project_id IS NULL",
                    connection);
                noProjectsCount = (int)cmd.ExecuteScalar();

            }
        }


        [TestCleanup]
        public void Cleanup()
        {
            scope.Dispose();
        }

        [TestMethod]
        public void GetAllEmployees_Test()
        {
            EmployeeSqlDAL getEmployeeTest = new EmployeeSqlDAL(connectionString);
            List<Employee> employeeList = getEmployeeTest.GetAllEmployees();

            Assert.IsNotNull(employeeList);
            Assert.AreEqual(employeeCount + 1, employeeList.Count);
        }

        [TestMethod]
        public void Search_Test()
        {
            EmployeeSqlDAL getEmployeeTest = new EmployeeSqlDAL(connectionString);
            List<Employee> empSearchTest = getEmployeeTest.Search("Test", "Employee");

            CollectionAssert.AllItemsAreNotNull(empSearchTest);
            Assert.AreEqual(1, empSearchTest.Count);
            Equals("Test",empSearchTest[0].FirstName);
        }

        [TestMethod]
        public void GetEmployeesWithoutProjects_Test()
        {
            EmployeeSqlDAL getEmployeeTest = new EmployeeSqlDAL(connectionString);
            List<Employee> noProjectList = getEmployeeTest.GetEmployeesWithoutProjects();

            Assert.AreEqual(noProjectsCount, noProjectList.Count);
        }
    }
}
