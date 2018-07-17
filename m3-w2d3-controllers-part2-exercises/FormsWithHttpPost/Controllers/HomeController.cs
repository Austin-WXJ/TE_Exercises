using FormsWithHttpPost.DAL;
using FormsWithHttpPost.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormsWithHttpPost.Controllers
{
    public class HomeController : Controller
    {
        IReviewDAL dal;
        string connectionString;

        public HomeController()
        {
            connectionString = ConfigurationManager.ConnectionStrings["SquirrelReviews"].ConnectionString;
            dal = new ReviewSqlDAL(connectionString);
        }


        // GET: Home
        public ActionResult Index()
        {
            List<Review> reviewList = dal.GetAllReviews();
            return View(reviewList);
        }

        public ActionResult NewReview()
        {
            return View("NewReview");
        }

        [HttpPost]
        public ActionResult PostReview(Review review)
        {
            if (ModelState.IsValid)
            {
                dal.NewReview(review);
                return RedirectToAction("Confirmation", review);
            }
            else
            {
                return View("NewReview");
            }
        }

        public ActionResult Confirmation()
        {
            return View("Confirmation");
        }

    }
}