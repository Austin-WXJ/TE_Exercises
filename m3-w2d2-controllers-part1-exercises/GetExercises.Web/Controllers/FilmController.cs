using GetExercises.Web.DAL.Interfaces;
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
        private IFilmDAL dal;

        /// <summary>
        /// The MVC framework with the assistance of Ninject, automatically passes in a FilmDAL.
        /// </summary>
        /// <param name="dal"></param>
        public FilmController(IFilmDAL dal)
        {
            this.dal = dal;
        }

        /// <summary>
        /// The request to display an empty search page.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return null;
        }

        /// <summary>
        /// Receives the search result request and goes to th database looking for the information.
        /// </summary>
        /// <param name="request">A request model that contains the search parameters.</param>
        /// <returns></returns>
        public ActionResult SearchResult(/*FilmSearch request */)
        {
            /* Call the DAL and pass the values as a model back to the View */
            return null;
        }
    }
}