using GetExercises.Web.DAL.Interfaces;
using GetExercises.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GetExercises.Web.DAL
{
    public class CustomerDAL : ICustomerDAL
    {
        private string connectionString;
        private string sql =    "SELECT first_name, last_name , email, active " +
                                "FROM customer " +
                                "WHERE last_name LIKE '%@search%' OR first_name LIKE '%@search%' " +
                                "ORDER BY ";

        public CustomerDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IList<Customer> SearchForCustomers(string search, string sortBy)
        {
            IList<Customer> customers = new List<Customer>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                switch (sortBy)
                {
                    case "active":
                        sql += $"{sortBy}";
                        break;
                    case "email":
                        sql += $"{sortBy}";
                        break;
                    case "last_name":
                        sql += $"{sortBy}";
                        break;
                }

                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                
                cmd.Parameters.AddWithValue("@search", search);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    customers.Add(MapRowToCustomer(reader));
                }

                return customers;
            }
        }

        private Customer MapRowToCustomer(SqlDataReader reader)
        {
            return new Customer()
            {
                FirstName = Convert.ToString(reader["first_name"]),
                LastName = Convert.ToString(reader["last_name"]),
                Email = Convert.ToString(reader["email"]),
                IsActive = Convert.ToBoolean(reader["active"])
            };
        }
    }
}