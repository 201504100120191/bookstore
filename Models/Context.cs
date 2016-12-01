using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Online_Book_Store.Models
{
    public class Context:DbContext
    {
        public Context() : base(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Guddee\Documents\Online_Book_Store\App_Data\Database1.mdf;Integrated Security=True") { }

        public DbSet<Registration> Registrations { get; set; }

        public DbSet<AdminLogin> admin { get; set; }

        public DbSet<Add_Book> Add_Book { get; set; }

        public DbSet<Feedback> Feedbacks { get; set; }

        public DbSet<Book_Category> Book_Category { get; set; }

    }
}