using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Online_Book_Store.Models
{
    public class AdminLogin
    {
        [Key]
        public int AdminID { get; set; }

        [Required(ErrorMessage = "Please enter EmailID")]
        public string username { get; set; }

        [Required(ErrorMessage = "Please enter Password")]
        public string password { get; set; }
    }
}