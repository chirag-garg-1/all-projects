using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryManagementSystem.Models
{
    public class Librarian
    {
        [Required(ErrorMessage = "Username Cannot be Empty")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password Cannot be Empty")]
        public string Password { get; set; }
    }
}