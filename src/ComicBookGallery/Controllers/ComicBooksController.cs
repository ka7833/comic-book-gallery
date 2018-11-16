using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController: Controller
    {
        public ActionResult Detail()
        {
            return View();
            /*
            if(DateTime.Today.DayOfWeek == DayOfWeek.Thursday)
            {
                return Redirect("/");
                //return new RedirectResult("/");
            }

            return Content("Hello from the comic books controller!");
            //return new ContentResult()
            //{
            //    Content = "Hello from the comic books controller!"
            //}; */
        }
    }
}