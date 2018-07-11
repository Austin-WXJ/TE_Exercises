using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FormsWithHttpPost.Models;
using System.Data.SqlClient;

namespace FormsWithHttpPost.DAL
{
    public class ReviewSqlDAL : IReviewDAL
    {
        private string conectionstring;

        public ReviewSqlDAL(string conectionstring)
        {
            this.conectionstring = conectionstring;
        }


        public List<Review> GetAllReviews()
        {
            throw new NotImplementedException();
        }

        public bool SaveReview(Review newReview)
        {
            throw new NotImplementedException();
        }
    }
}