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
    public class ReviewController : Controller
    {

        IReviewDAL dal;
        string connectionString;

        public ReviewController()
        {
            connectionString = ConfigurationManager.ConnectionStrings["SquirrelReviews"].ConnectionString;
            dal = new ReviewSqlDAL(connectionString);
        }

        [HttpPost]
        public ActionResult Index(Review review)
        {
            return View("PostReview");
        }

        [HttpPost]
        public ActionResult PostReview(Review review)
        {
            dal.NewReview(review);
            return RedirectToAction("Confirmation", "Review");
        }

        public ActionResult Confirmation()
        {
            return View("Confirmation");
        }
    }
}