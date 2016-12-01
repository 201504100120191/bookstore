using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Online_Book_Store.Models
{
    public class Book_Category
    {
        [Key]
        public int cid { get; set; }
        [Required]
        public string Category { get; set; }

        public ICollection<Add_Book> ab { get; set; }
    }
    public class Add_Book
    {
        public int id { get; set; }

        [Required]
        public string bname { get; set; }

        [Required]
        public string btitle { get; set; }

        [Required]
        public string author { get; set; }

        [Required]
        public string publication { get; set; }

        [Required]
        public double price { get; set; }

        public string b_img { get; set; }

        public string b_file { get; set; }

        public int cid { get; set; }
        public virtual Book_Category b { get; set; }

    }
}