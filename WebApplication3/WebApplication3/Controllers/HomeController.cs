using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to my application!";
            return View(new MyModel());
        }
        public ActionResult CalculateSecondLargest(MyModel model)
        {
            if (string.IsNullOrEmpty(model.Numbers))
            {
                ViewBag.Message = "Please enter numbers to find the second largest.";
                return View("Index", model);
            }
                        
            string[] numberStrings = model.Numbers.Split(',');
            List<int> numbers = new List<int>();

            foreach (var numberString in numberStrings)
            {
                if (int.TryParse(numberString, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    ViewBag.Message = "Invalid input. Please enter valid numbers separated by commas.";
                    return View("Index", model);
                }
            }

            if (numbers.Count < 2)
            {
                ViewBag.Message = "Please enter at least two numbers to find the second largest.";
                return View("Index", model);
            }
            model.SecondLargest = numbers.OrderByDescending(x => x).Skip(1).FirstOrDefault();

            ViewBag.Message = "Second largest number calculated successfully!";
            return View("Index", model);
        }
    }
}
