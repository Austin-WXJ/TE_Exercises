using SSGeek.Models;
using SSGeek.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;

namespace SSGeek.Controllers
{
    public class ShoppingCartController : Controller
    {
        string connectionString;
        IProductDAL dal;

        public ShoppingCartController()
        {
            connectionString = ConfigurationManager.ConnectionStrings["SSGeek"].ConnectionString;
            dal = new ProductSqlDAL(connectionString);
        }

        // GET: ShoppingCart
        [HttpGet]
        public ActionResult Index()
        {
            List<Product> inventory = dal.GetProducts();
            return View(inventory);
        }

        public ActionResult ViewProduct(int id)
        {
            Product product = dal.GetProduct(id);

            return View("ViewProduct", product);
        }

        public ActionResult ViewCart()
        {
            ShoppingCartModel cart = GetActiveShoppingCart();
            return View(cart);
        }

        [HttpPost]
        public ActionResult AddToCart(int id, int quantity)
        {

            var product = dal.GetProduct(id);

            ShoppingCartModel cart = GetActiveShoppingCart();


            cart.AddToCart(product, quantity);

            Session["Shopping_Cart"] = cart;

            return RedirectToAction("ViewCart", cart);
        }
        private ShoppingCartModel GetActiveShoppingCart()
        {
            ShoppingCartModel cart = null;

            if (Session["Shopping_Cart"] == null)
            {
                cart = new ShoppingCartModel();
                Session["Shopping_Cart"] = cart;
            }
            else
            {
                cart = Session["Shopping_Cart"] as ShoppingCartModel;
            }
            return cart;
        }
    }
}