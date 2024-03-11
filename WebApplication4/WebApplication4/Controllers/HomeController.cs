using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.myproperty = "My Name is Chirag";

            ViewBag.MyList = new List<string>() { "chirag","raghav","Sparsh"};
            return View();
        }      
    }
}