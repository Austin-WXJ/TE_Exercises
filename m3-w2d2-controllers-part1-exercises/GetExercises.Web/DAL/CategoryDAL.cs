using GetExercises.Web.DAL.Interfaces;
using GetExercises.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GetExercises.Web.DAL
{
    public class CategoryDAL : ICategoryDAL
    {
        private string connectionString;
        private const string sql = "SELECT name FROM category";

        public CategoryDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IList<string> GetCategories()
        {
            IList<string> categoryList = new List<string>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    categoryList.Add(MapToCategory(reader));
                }

                return categoryList;
            }
        }

        private string MapToCategory(SqlDataReader reader)
        {
            return Convert.ToString(reader["name"]);
        }
    }
}