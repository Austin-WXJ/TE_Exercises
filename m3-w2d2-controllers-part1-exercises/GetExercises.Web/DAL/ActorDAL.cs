using GetExercises.Web.DAL.Interfaces;
using GetExercises.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GetExercises.Web.DAL
{
    public class ActorDAL : IActorDAL
    {
        private string connectionString;

        public ActorDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IList<Actor> FindActors(string lastNameSearch)
        {
            IList<Actor> actors = new List<Actor>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT first_name, last_name FROM actor WHERE last_name LIKE @last_name ORDER BY last_name", conn);
                cmd.Parameters.AddWithValue("@last_name", "%" + lastNameSearch + "%");

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    actors.Add(MapRowToActor(reader));
                }
            }

            return actors;
        }

        private Actor MapRowToActor(SqlDataReader reader)
        {
            return new Actor()
            {
                FirstName = Convert.ToString(reader["first_name"]),
                LastName = Convert.ToString(reader["last_name"])
            };
        }
    }
}