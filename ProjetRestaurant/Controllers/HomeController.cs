using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetRestaurant.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Restaurant()
        {
            ViewBag.Message = "La page du Restaurant.";

            return View();
        }

        public ActionResult Carte()
        {
            ViewBag.Message = "La Carte.";

            return View();
        }
    }
}