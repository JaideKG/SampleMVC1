using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Default()
        {
            Random rand = new Random();
            int n = rand.Next(1, 3);
            if (n % 2 == 0) {
                return View("Index");
            } else
            {
                return View("About");
            }
        }

        public ActionResult Index()
        {
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