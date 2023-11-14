using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab7.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Made by Luke, Kene, Sam, and Camden.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Us:";

            return View();
        }
    }
}