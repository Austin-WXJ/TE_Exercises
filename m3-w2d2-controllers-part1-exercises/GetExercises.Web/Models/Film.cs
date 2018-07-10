using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetExercises.Web.Models
{
    public class Film
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int ReleaseYear { get; set; }
        public int Length { get; set; }
        public string Rating { get; set; }
    }
}