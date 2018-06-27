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

        [TestInitialize]
        public void Initialze()
        {
            scope = new TransactionScope();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

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
        }

        [TestMethod]
        public void Search_Test()
        {

        }

        [TestMethod]
        public void GetEmployeesWithoutProjects_Test()
        {

        }
    }
}
