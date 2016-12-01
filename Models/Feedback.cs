using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Online_Book_Store.Models
{
    public class Feedback
    {
        public int id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [Required]
        [RegularExpression(@"\d{10}",ErrorMessage="Mobile no must be 10 digit")]
        public string contact { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string query { get; set; }
    }
}