using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Week3Project.Models
{
    public class ReturnDateModel
    {
        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Issue date is required.")]
        [DataType(DataType.DateTime)]
        public DateTime IssueDate { get; set; }

        [Required(ErrorMessage ="Return Date is Required.")]
        [DataType(DataType.DateTime)]
        public DateTime ReturnDate { get; set;}
    }
}