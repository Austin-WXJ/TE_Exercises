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

        public Product GetProduct(int id)
        {
			throw new NotImplementedException();
        }
       
        public List<Product> GetProducts()
        {
            throw new NotImplementedException();
        }

		
    }
}