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
    public class DepartmentTest
    {
        private TransactionScope scope;
        private string connectionString = @"Data Source=.\SQLexpress;Initial Catalog=Projects;Integrated Security=True";
        private int deptCount = 0;
        private int departmentCode = 0;

        [TestInitialize]
        public void Initialize()
        {
            scope = new TransactionScope();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd;
                connection.Open();
                cmd = new SqlCommand("SELECT COUNT(*) FROM department", connection);
                deptCount = (int)cmd.ExecuteScalar();

                cmd = new SqlCommand("INSERT INTO department (name) VALUES ('TestDepartment'); SELECT CAST(SCOPE_IDENTITY() as int);", connection);
                departmentCode =  (int)cmd.ExecuteScalar();

                cmd = new SqlCommand("UPDATE department SET name = 'TestDepartment2' WHERE name = 'TestDepartment'", connection);
                cmd.ExecuteNonQuery();
            }

        }

        [TestCleanup]
        public void Cleanup()
        {
            scope.Dispose();
        }

        [TestMethod()]
        public void GetDepartmentsTest()
        {
            DepartmentSqlDAL getDepartmentTest = new DepartmentSqlDAL(connectionString);
            List<Department> deptList = getDepartmentTest.GetDepartments();

            Assert.IsNotNull(deptList);
            Assert.AreEqual(deptCount + 1, deptList.Count);
        }

        [TestMethod]
        public void CreateDeptartmentTest()
        {
            DepartmentSqlDAL createDeptTest = new DepartmentSqlDAL(connectionString);
            Department testCreateDept = new Department();
            testCreateDept.Name = "TestDeptCreate";
            bool didWork = createDeptTest.CreateDepartment(testCreateDept);
            List<Department> deptList = createDeptTest.GetDepartments();

            Assert.IsTrue(didWork);
            Assert.AreEqual(deptCount + 2, deptList.Count);
        }

        [TestMethod]
        public void UpdateDepartmentTest()
        {
            DepartmentSqlDAL updateDeptTest = new DepartmentSqlDAL(connectionString);
            Department testUpdateDept = new Department();
            testUpdateDept.Name = "TestDepartment3";
            testUpdateDept.Id = departmentCode;
            bool didWork = updateDeptTest.UpdateDepartment(testUpdateDept);

            Assert.IsTrue(didWork);
        }
    }
}
