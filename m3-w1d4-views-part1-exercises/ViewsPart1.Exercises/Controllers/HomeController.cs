using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewsPart1.Exercises.Controllers
{
    public class HomeController : Controller
    {
        //GET: Index
        // /
        // /Home
        // /Home/Index
        public ActionResult Index()
        {
            return View("Index");
        }

        // GET: FizzBuzz
        // /Home/FizzBuzz
        public ActionResult FizzBuzz()
        {
            return View("FizzBuzz");
        }

        // GET: Fibonacci
        // /Home/Fibonacci
        public ActionResult Fibonacci()
        {
            return View("Fibonacci");
        }

        // GET: Echo
        // /Home/Echo
        public ActionResult Echo()
        {
            return View("Echo");
        }
    }
}