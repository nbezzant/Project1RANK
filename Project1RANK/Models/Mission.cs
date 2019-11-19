using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Project1RANK.Models;


namespace Project1RANK.Models
{
    public class Mission
    {
        [Required]
        [Display(Name ="Mission Number")]
        public int Mission_ID { get; set; }


        [Display(Name = "Mission")]
        [Required]
        public string Mission_Name { get; set; }

        [Display(Name = "Mission President")]
        [Required]
        public string Mission_President_Name { get; set; }

        [Display(Name = "Address")]
        [Required]
        public string Mission_Address { get; set; }

        [Display(Name = "Language")]
        [Required]
        public string Mission_Language { get; set; }

        [Display(Name = "Climate")]
        [Required]
        public string Mission_Climate { get; set; }

        [Display(Name = "Main Religion")]
        [Required]
        public string Mission_Religion { get; set; }

        [Display(Name = "Flag")]
        [Required]
        public string Mission_Flag { get; set; }

        [Display(Name ="FAQ #1:")]
        public string Mission_FAQ_1 { get; set; }

        public string Mission_FAQ_1_Answer { get; set; }

        [Display(Name = "FAQ #2:")]
        public string Mission_FAQ_2 { get; set; }

        public string Mission_FAQ_2_Answer { get; set; }
    }
}