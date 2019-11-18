using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project1RANK.Models
{
    public class User
    {
        [Required]
        public int User_ID { get; set; }


        [Required]
        public string User_Email { get; set; }


        [Required]
        public string User_Password { get; set; }


        [Required]
        public string User_First_Name { get; set; }


        [Required]
        public string User_Last_Name { get; set; }
    }
}