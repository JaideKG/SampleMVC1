using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp1.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        public ActionResult Index()
        {
            return View();
        }

        //parameters are automatically parsed in from query string
        public ActionResult Register(string make="Pontiac", 
            string plate="Aztek", int year=2000)
        {
            ViewBag.Make = make;
            ViewBag.Plate = plate;
            ViewBag.Year = year;
            return View();
        }
    }
}