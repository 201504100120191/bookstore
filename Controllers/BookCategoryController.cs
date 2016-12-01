using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Online_Book_Store.Models;

namespace Online_Book_Store.Controllers
{
    public class BookCategoryController : Controller
    {
        private Context db = new Context();

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Book_Category book_category)
        {
            if (ModelState.IsValid)
            {
                db.Book_Category.Add(book_category);
                db.SaveChanges();
                //return RedirectToAction("Index");
            }

            return View(book_category);
        }
    }
}