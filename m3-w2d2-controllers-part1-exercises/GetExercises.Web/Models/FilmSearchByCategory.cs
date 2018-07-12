using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GetExercises.Web.DAL;
using GetExercises.Web.DAL.Interfaces;

namespace GetExercises.Web.Models
{
    public class FilmSearchByCategory
    {

        public string Genre { get; set; }
        public int MinLength { get; set; }
        public int MaxLength { get; set; }
        public IList<string> Genres { get; internal set; }
    }
}