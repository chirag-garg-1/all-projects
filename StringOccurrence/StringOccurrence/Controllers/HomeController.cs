using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StringOccurrence.Models;

namespace StringOccurrence.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FindNthOccurrence(Mymodel model)
        {
            if (string.IsNullOrWhiteSpace(model.InputString))
            {
                ViewBag.ResultMessage = "Please Enter a Valid String";
            }
            else
            {
                int OccurrencePosition = FindNthOccurrenceOfTheWord(model.InputString, model.OccurrencePosition);
                if (OccurrencePosition != int.MinValue)
                {
                    ViewBag.ResultMessage = $"The {model.NthOccurrence}th Occurrence of 'the' is found at position {OccurrencePosition}.";
                }
                else
                {
                    ViewBag.ResultMessage = $"The Word 'the' does not occur {model.NthOccurrence} Times in the given string.";
                }
            }
            return View("Index", model);
        }

        private int FindNthOccurrenceOfTheWord(string input, int n) 
        {
            int Count = 0;
            int Index = int.MinValue;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.ToLower(input[i]) == 't' && i + 2 < input.Length &&
                    char.ToLower(input[i + 1]) == 'h' && char.ToLower(input[i + 2]) == 'e')
                {
                    Count++;
                    if (Count == n)
                    {
                        Index = i + 1; 
                        break;
                    }
                }
            }
            return Index;
        }
    }
}