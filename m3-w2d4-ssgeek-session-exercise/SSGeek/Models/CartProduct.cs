using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSGeek.Models
{
    public class CartProduct
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double Total
        {
            get
            {
                return Quantity * Product.Price;
            }
        }
    }
}