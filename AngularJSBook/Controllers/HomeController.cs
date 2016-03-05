using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AngularJSBook.Repositories;
using AngularJSBook.Domain;


namespace AngularJSBook.Controllers
{
    public class HomeController : Controller
    {

        private BookStoreContext db = new BookStoreContext();

        public ActionResult Index()
        {

            var xx = db.Books.ToList();
            var ddd = xx.Count;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}