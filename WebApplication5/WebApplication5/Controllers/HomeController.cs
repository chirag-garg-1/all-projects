using System;
using System.Web.Mvc;
using StringOccurrence.Models;

namespace YourNamespaceStringOccurrence.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new StringOccurrenceModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult FindOccurrence(StringOccurrenceModel model)
        {
            if (ModelState.IsValid)
            {
                model.OccurrenceResult = FindNthOccurrenceOfThe(model.InputString, model.OccurrenceNumber);
                return View("Index", model);
            }
            return View("Index", model);
        }
        private string FindNthOccurrenceOfThe(string input, int n)
        {
            int index = -1;
            for (int i = 0; i < n; i++)
            {
                index = input.IndexOf("the", index + 1, StringComparison.OrdinalIgnoreCase);
                if (index == -1)
                {
                    ViewBag.Message = $"There is no {n}th occurrence of the word 'the' in the given string.";
                }
                else
                {
                    ViewBag.Message = $"Found at {index}";
                }
            }
            return ViewBag.Message;
        }
    }
}
