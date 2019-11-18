using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project1RANK.Models
{
    public class MissionQuestion
    {

        [Required]
        public int Mission_Question_ID { get; set; }


        [Required]
        public int Mission_ID { get; set; }


        [Required]
        public int User_ID { get; set; }


        [Required]
        public string Question { get; set; }


        [Required]
        public string Answer { get; set; }

    }
}