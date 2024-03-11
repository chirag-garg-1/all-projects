using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Week3Project.Models
{
    public class BranchModel
    {
        [Required(ErrorMessage ="Name is required")]
        public String Name { get; set; }
        public int Id { get; set; }
    }
}