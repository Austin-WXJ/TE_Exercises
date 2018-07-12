using GetExercises.Web.DAL.Interfaces;
using GetExercises.Web.DAL;
using GetExercises.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GetExercises.Web.Controllers
{
    public class FilmController : Controller
    {
        private IFilmDAL filmDal;


        /// <summary>
        /// The MVC framework with the assistance of Ninject, automatically passes in a FilmDAL.
        /// </summary>
        /// <param name="dal"></param>
        public FilmController(IFilmDAL filmDal)
        {
            this.filmDal = filmDal;
        }

        /// <summary>
        /// The request to display an empty search page.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Receives the search result request and goes to th database looking for the information.
        /// </summary>
        /// <param name="request">A request model that contains the search parameters.</param>
        /// <returns></returns>
        public ActionResult SearchResult(string category, int minLength, int maxLength)
        {

            //http://localhost:50749/film/searchresult?category=comedy&minlength=60&maxlength=120
            /* Call the DAL and pass the values as a model back to the View */
            IList<Film> filmList = dal.GetFilmsBetween(category, minLength, maxLength);
            //return View(filmList);
            return View(filmList);
        }

    }
}