using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSGeek.Models
{
    public class ShoppingCartModel
    {
        public IList<CartProduct> Items { get; } = new List<CartProduct>();

        public double GrandTotal
        {
            get
            {
                double grandTotal = 0;
                foreach (CartProduct item in Items)
                {
                   grandTotal += item.Total;
                }
                return grandTotal;
            }
        }

        public void AddToCart(Product p, int quantity)
        {
            CartProduct shoppingCartItem = null;
            foreach (CartProduct item in Items)
            {
                if (item.Product.ProductId == p.ProductId)
                {
                    shoppingCartItem = item;
                }
            }

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new CartProduct() { Product = p, Quantity = quantity };
                Items.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Quantity += quantity;
            }
        }

        
    }
}