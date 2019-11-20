using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project1RANK.Models
{
    public class RealTimeCommenting
    {
        [Display(Name="Name: ")]
        [Required(ErrorMessage ="Must enter name to comment")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Must enter text to comment")]
        [Display(Name = "Reply: ")]
        public string Body { get; set; }
    }
}