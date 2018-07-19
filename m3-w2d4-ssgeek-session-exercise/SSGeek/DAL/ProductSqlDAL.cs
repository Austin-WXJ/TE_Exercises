using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SSGeek.Models;
using System.Data.SqlClient;

namespace SSGeek.DAL
{
    public class ProductSqlDAL : IProductDAL
    {
        string connectionString;
        string getProducts_Sql = "SELECT * FROM products";

        public ProductSqlDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public Product GetProduct(int id)
        {
            IList<Product> products = GetProducts();
            Product product = null;
            foreach (Product item in products)
            {
                if (item.ProductId == id)
                {
                    product = item;
                }
            }
            return product;
        }
       
        public List<Product> GetProducts()
        {
            List<Product> inventory = new List<Product>();

            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(getProducts_Sql, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    inventory.Add(MapToInventory(reader));
                }
            }
            return inventory;
        }


        private Product MapToInventory(SqlDataReader reader)
        {
            return new Product()
            {
               Description = Convert.ToString(reader["description"]),
               ImageName = Convert.ToString(reader["image_name"]),
               Name = Convert.ToString(reader["name"]),
               Price = Convert.ToDouble(reader["price"]),
               ProductId = Convert.ToInt32(reader["product_id"])
            };
        }
    }
}