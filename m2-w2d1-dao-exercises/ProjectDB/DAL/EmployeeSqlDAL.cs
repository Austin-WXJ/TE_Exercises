using ProjectDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDB.DAL
{
    public class EmployeeSqlDAL
    {
        private string connectionString;

        // Single Parameter Constructor
        public EmployeeSqlDAL(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public List<Employee> GetAllEmployees()
        {
            throw new NotImplementedException();
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
