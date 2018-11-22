using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComicBookGallery.Data;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController: Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        public ActionResult Detail(int? id)
        {
            if(id == null)
            {
                return HttpNotFound();
            }
            var comicBook = _comicBookRepository.GetComicBook((int)id);
            return View(comicBook);
            //return View(comicBook);
            //ViewBag.ComicBook = comicBook;

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