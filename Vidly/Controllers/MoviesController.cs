using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            Movie movie = new Movie() {Name = "Shrek"};
            return View(movie);
            //return Content("Hello World!");   //Content Action send a Text
            //return HttpNotFound();            // Send a Page not found page
            //return new EmptyResult();         // Yeilds an empty page
            //return RedirectToAction("Index", "Home", new {page =1, sortby="name"});   // redirects the page with parameters

        }

        //  mvcaction4 = Shortcut to create ActionResult methods....

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month); // just display the year and the month...
        }


        public ActionResult Edit(int id)
        {
            return Content("id=" + id); // Creates a Page named Edit with Paramater value=1
                                        //  which is passed in the method....
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(string.Format("pageIndex={0} & sortBy={1}", pageIndex, sortBy));

            // view page:   http://localhost:7361/movies?pageIndex=2&sortBy=%22release%22
        }

    }
}