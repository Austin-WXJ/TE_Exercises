using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SSGeek.Models;
using System.Data.SqlClient;

namespace SSGeek.DAL
{
    public class ForumPostSqlDAL : IForumPostDAL
    {       
        
        public List<ForumPost> GetAllPosts()
        {
			throw new NotImplementedException();
        }

        public bool SaveNewPost(ForumPost post)
        {
            throw new NotImplementedException();
        }
    }
}