using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Week3Project.Models
{
    public class PublicationModel
    {
        [Required(ErrorMessage ="Publication id is required.")]
        public int PublicationId { get; set; }

        [Required(ErrorMessage ="Title is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage ="Year is required")]
        [Range(1900, int.MaxValue,ErrorMessage ="Please enter valid publication year.")]
        public int Year { get; set; }

        [Required(ErrorMessage ="Author is Required.")]
        public string Author { get; set; }
        public int Id { get; set; }

        [Required(ErrorMessage ="Branch is required.")]
        public string Branch { get; set; }
    }
}