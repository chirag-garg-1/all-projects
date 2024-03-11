using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagementSystem.Models
{
    public class Book
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Stock { get; set; }
        public string Branch { get; set; }

    }
}