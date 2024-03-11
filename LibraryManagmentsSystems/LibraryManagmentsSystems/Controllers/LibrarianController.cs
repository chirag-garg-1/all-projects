using LibraryManagementSystem.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryManagementSystem.Controllers
{
    public class LibrarianController : Controller
    {
        public static List<StudentModel> studentsList = new List<StudentModel>();
        private static List<string> branches = new List<string>();
        private static List<Publication> publications = new List<Publication>();
        public static List<IssuedBook> issuedBooks = new List<IssuedBook>();
        public static List<IssuedBook> returnedBooks = new List<IssuedBook>();
        private static List<Book> books = new List<Book>();
        private int publicationID = 0;

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Librarian model)
        {
            if (model.Username == "admin" && model.Password == "admin")
            {
                return RedirectToAction("Dashboard");
            }
            else if (string.IsNullOrWhiteSpace(model.Username) || string.IsNullOrWhiteSpace(model.Password))

            {
                TempData["Message"] = "Username or Password Cannot be Empty";
                return View("Login", model);
            }
            else
            {
                TempData["Message"] = "Invalid Username or Password";
                return View("Login", model);
            }
        }
        public ActionResult Dashboard(Librarian model)
        {
            return View("Dashboard", model);
        }
        public ActionResult RegisterStudent()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegisterStudent(StudentModel student)
        {
            if (string.IsNullOrWhiteSpace(student.Id))
            {
                TempData["Message"] = "Id Cannot be Empty";
                return View();
            }
            else if (string.IsNullOrWhiteSpace(student.Name))
            {
                TempData["Message"] = "Name Cannot be Empty";
                return View();
            }
            else if (string.IsNullOrWhiteSpace(student.Username))
            {
                TempData["Message"] = "Username Cannot be Empty";
                return View();
            }
            else if (string.IsNullOrWhiteSpace(student.Password))
            {
                TempData["Message"] = "Password Cannot be Empty";
                return View();
            }
            else
            {
                var findStudentID = studentsList.Find(x => x.Id == student.Id);
                var findStudentUsername = studentsList.Find(x => x.Username == student.Username);
                if (findStudentID != null)
                {
                    TempData["Message"] = "Student with this ID already Exists";
                    return View();
                }
                else if (findStudentUsername != null)
                {
                    TempData["Message"] = "Student with this Username Already Exists";
                    return View();
                }
                else
                {
                    studentsList.Add(student);
                    TempData["Message"] = "Student added successfully.";
                    return RedirectToAction("RegisterStudent", student);
                }
            }
        }
        public ActionResult AddBranch()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddBranch(Branch branch)
        {
            if (string.IsNullOrWhiteSpace(branch.Name))
            {
                TempData["SuccessMessage"] = "Branch Name Cannot be Empty";
                return View();
            }
            else
            {
                if (branches.Contains(branch.Name))
                {
                    TempData["SuccessMessage"] = "Branch Already Exists";
                }
                else
                {
                    branches.Add(branch.Name);
                    TempData["SuccessMessage"] = "Branch added successfully.";
                }
            }
            return RedirectToAction("AddBranch", branch);
        }

        public ActionResult BookIssue()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BookIssue(IssuedBook issuedBook)
        {
            var findBook = books.Find(x => x.Id == issuedBook.Id);
            var findStudent = studentsList.Find(x => x.Id == issuedBook.StudentId);
            if (string.IsNullOrWhiteSpace(issuedBook.Id))
            {
                TempData["Message"] = "Issue Id Cannot be Empty";
                return View();
            }
            else if (string.IsNullOrWhiteSpace(issuedBook.StudentId))
            {
                TempData["Message"] = "Student ID Cannot be Empty";
                return View();
            }
            else if (string.IsNullOrWhiteSpace(issuedBook.BookId))
            {
                TempData["Message"] = "Book Id Cannot be Empty";
                return View();
            }
            else if (string.IsNullOrWhiteSpace(issuedBook.IssueDate))
            {
                TempData["Message"] = "Issue Date Cannot be Empty";
                return View();
            }
            else if (findStudent == null)
            {
                TempData["Message"] = "Student with this ID doesn't Exist";
                return View();
            }
            else if (findBook == null)
            {
                TempData["Message"] = "Book with this ID doesn't Exist";
                return View();
            }
            else
            {
                issuedBooks.Add(issuedBook);
                TempData["Message"] = "Book Issued successfully.";
            }
            return RedirectToAction("BookIssue", issuedBook);
        }
        public ActionResult BookReturn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BookReturn(IssuedBook returnedBook)
        {
            var findBook = books.Find(x => x.Id == returnedBook.Id);
            var findStudent = studentsList.Find(x => x.Id == returnedBook.StudentId);
            if (string.IsNullOrWhiteSpace(returnedBook.Id))
            {
                TempData["Message"] = "Issue Id Cannot be Empty";
                return View();
            }
            else if (string.IsNullOrWhiteSpace(returnedBook.StudentId))
            {
                TempData["Message"] = "Student ID Cannot be Empty";
                return View();
            }
            else if (string.IsNullOrWhiteSpace(returnedBook.BookId))
            {
                TempData["Message"] = "Book Id Cannot be Empty";
                return View();
            }
            else if (string.IsNullOrWhiteSpace(returnedBook.ReturnDate))
            {
                TempData["Message"] = "Return Date Cannot be Empty";
                return View();
            }
            else if (findStudent == null)
            {
                TempData["Message"] = "Student with this ID doesn't Exist";
                return View();
            }
            else if (findBook == null)
            {
                TempData["Message"] = "Book with this ID doesn't Exist";
                return View();
            }
            else
            {
                IssuedBook bookToRemove = issuedBooks.Find(book => book.Id == returnedBook.Id);
                issuedBooks.Remove(bookToRemove);
                returnedBooks.Add(returnedBook);
                TempData["Message"] = "Book Returned Successfully.";
            }
            return View("BookReturn", returnedBook);
        }

        public ActionResult AddStock()
        {
            ViewBag.Branches = new List<string>(branches);
            return View();
        }

        [HttpPost]
        public ActionResult AddStock(Book book)
        {
            ViewBag.Branches = new List<string>(branches);
            if (string.IsNullOrWhiteSpace(book.Id))
            {
                TempData["Message"] = "Book Id Cannot be Empty";
                return View();
            }
            else if (string.IsNullOrWhiteSpace(book.Title))
            {
                TempData["Message"] = "Title Cannot be Empty";
                return View();
            }
            else if (string.IsNullOrWhiteSpace(book.Stock))
            {
                TempData["Message"] = "Stock Cannot be Empty";
                return View();
            }
            else if (branches.Count < 1)
            {
                TempData["Message"] = "No Branch Selected";
                return View();
            }
            else
            {
                var findBook = books.Find(x => x.Id == book.Id);
                if (findBook != null)
                {
                    book.Stock += findBook.Stock;
                    TempData["Message"] = "Book Already Exists and Stock has been Updated";
                    return RedirectToAction("AddStock", book);
                }
                else
                {
                    books.Add(book);
                    TempData["Message"] = "Stock Added Successfully";
                    return RedirectToAction("AddStock", book);
                }
            }

        }
        public ActionResult AddPublication()
        {
            ViewBag.Branches = new List<string>(branches);
            return View();
        }

        [HttpPost]
        public ActionResult AddPublication(Publication publication)
        {
            ViewBag.Branches = new List<string>(branches);
            publication.Id = publicationID.ToString();
            publicationID++;
            if (string.IsNullOrWhiteSpace(publication.Title))
            {
                TempData["Message"] = "Title Cannot be Empty";
                return View();
            }
            else
            {
                publications.Add(publication);
                TempData["Message"] = "Publication added successfully.";
            }
            return RedirectToAction("AddPublication", publication);
        }

    }
}