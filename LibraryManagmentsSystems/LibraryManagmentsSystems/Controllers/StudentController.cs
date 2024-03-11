using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryManagementSystem.Controllers
{


    public class StudentController : LibrarianController
    {
        private static List<string> VerifyStudent = new List<string>();
        public ActionResult StudentLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult StudentLogin(StudentModel student)
        {
            VerifyStudent.Clear();
            if (string.IsNullOrWhiteSpace(student.Username) || string.IsNullOrWhiteSpace(student.Password))
            {
                TempData["Message"] = "Username or Password Cannot be Empty";
                return View();
            }
            var findUsername = studentsList.Find(x => x.Username == student.Username);
            if (findUsername != null)
            {
                VerifyStudent.Add(student.Username);
                if (student.Password == findUsername.Password)
                {
                    return RedirectToAction("StudentDashboard");
                }
                else
                {
                    TempData["Message"] = "Wrong Password";
                    VerifyStudent.Clear();
                    return View();
                }
            }
            TempData["Message"] = "Student with this Username Doesn't Exist";
            VerifyStudent.Clear();
            return View("StudentLogin", student);
        }
        public ActionResult StudentDashboard(StudentModel model)
        {
            return View("StudentDashboard", model);
        }
        public ActionResult BookReport()
        {
            var bookIssued = issuedBooks.FirstOrDefault();
            var bookReturned = returnedBooks.FirstOrDefault();
            if (bookReturned != null)
            {
                return View(bookReturned);
            }
            else if (bookIssued != null)
            {
                return View(bookIssued);
            }
            else
            {
                TempData["Message"] = "No Books Issued Till Date";
                return RedirectToAction("BookReport");
            }
        }
        public ActionResult Account()
        {
            var studentToFind = studentsList.Find(x => x.Username == VerifyStudent[0]);
            if (studentToFind != null)
            {
                return View(studentToFind);
            }
            return RedirectToAction("Account");
        }
    }
}