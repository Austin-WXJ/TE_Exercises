using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormsWithHttpPost.Models
{
    public class NewReview
    {
        
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        [Range(1, 5)]
        public int Rating { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Message { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime ReviewDate { get; set; } = DateTime.Now;

        public int[] RatingList { get; } = Enumerable.Range(1, 5).ToArray();
    }
}