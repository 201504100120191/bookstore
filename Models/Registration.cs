using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Online_Book_Store.Models
{
    public class Registration
    {
        public int id { get; set; }
        
        [Required]
        public string name { get; set; }
        

        [DataType(DataType.MultilineText)]
        public string address { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [NotMapped]
        [DataType(DataType.Password)]

        [Required]
        [Compare("password")]
        public string cpassword { get; set; }

        [Required]
        [RegularExpression(@"\d{10}",ErrorMessage="Mobile no must be 10 digits")]
        public string contactno { get; set; }
    }
}