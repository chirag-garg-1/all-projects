using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagementSystem.Models
{
    public class IssuedBook
    {
        public string Id { get; set; }
        public string StudentId { get; set; }
        public string BookId { get; set; }
        public string IssueDate { get; set; }
        public string ReturnDate { get; set; }
    }
}