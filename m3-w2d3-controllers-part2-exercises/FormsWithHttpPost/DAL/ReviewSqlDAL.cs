using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FormsWithHttpPost.Models;
using System.Data.SqlClient;
using System.Configuration;

namespace FormsWithHttpPost.DAL
{
    public class ReviewSqlDAL : IReviewDAL
    {
        private string connectionString;
        private string sqlListAll = "SELECT * FROM reviews ";
        private string sqlInsert = "INSERT INTO review (username, rating, review_title, review_text, review_date) " +
                                   "VALUES (@userName, @rating, @title, @message, @date)";


        public ReviewSqlDAL(string connectionString)
        {

            this.connectionString = connectionString;
        }


        public List<Review> GetAllReviews()
        {
            List<Review> returnList = new List<Review>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sqlListAll, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    returnList.Add(MapRowToReview(reader));
                }
            }

            return returnList;
            throw new NotImplementedException();
        }

        public bool NewReview(Review newReview)
        {
            bool isSaved = false;

            using (SqlConnection conn = new SqlConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlInsert, conn);

                cmd.Parameters.AddWithValue("@userName", newReview.Username );
                cmd.Parameters.AddWithValue("@rating", newReview.Rating );
                cmd.Parameters.AddWithValue("@title", newReview.Title );
                cmd.Parameters.AddWithValue("@message", newReview.Message );
                cmd.Parameters.AddWithValue("@date", newReview.ReviewDate );

                int count = cmd.ExecuteNonQuery();
                if (count == 1)
                {
                    isSaved = true;
                }
            }
            return isSaved;
            throw new NotImplementedException();
        }

        private Review MapRowToReview(SqlDataReader reader)
        {
            return new Review()
            {
                Id = Convert.ToInt32(reader["review_id"]),
                Message = Convert.ToString(reader["review_text"]),
                Rating = Convert.ToInt32(reader["rating"]),
                ReviewDate = Convert.ToDateTime(reader["review_date"]),
                Title = Convert.ToString(reader["review_title"]),
                Username = Convert.ToString(reader["username"])
            };
        }
    }
}