using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoApp.Models;

namespace VideoApp.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            return View(movie); // pass the movie model to the view ( the Random view)
        }

        [Route("movies/released/{year}/{month}")]
        public ActionResult ByReleaseDate(int Year, int month)
        {
            return Content(Year + "/" + month);
        }

        public ActionResult Edit(int id) {  // we are passing in a non-optional value
            return Content("ID: " + id);
        }

        public ActionResult Index(int? page, String sortBy)
        {
            if (!page.HasValue)
            {
                page = 1;
            }

            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content(String.Format("?page={0}&sortBy=\"{1}\"", page, sortBy));
        }
    }
}