using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Week3Project.Models
{
    public class IssueDateModel
    {
        [Required(ErrorMessage ="Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Issue Date is required.")]
        [DataType(DataType.DateTime)]
        public DateTime IssueDate { get; set; }

        [Required(ErrorMessage ="Return Date is required")]
        [DataType(DataType.DateTime)]
        public DateTime ReturnDate { get; set;}
    }
}