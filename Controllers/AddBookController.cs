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
    public class AddBookController : Controller
    {
        private Context db = new Context();


        public ActionResult Create()
        {
            ViewBag.cid = new SelectList(db.Book_Category, "cid", "Category");
            return View();
        }

        [HttpPost]
        public ActionResult Create(HttpPostedFileBase fuimg, HttpPostedFileBase fufile,Add_Book add_book)
        {
            if (ModelState.IsValid)
            {
                String path = Request.PhysicalApplicationPath + @"\Book_img\";
                fuimg.SaveAs(path + "\\" + fuimg.FileName);
                add_book.b_img = fuimg.FileName.ToString();

                String path1 = Request.PhysicalApplicationPath + @"\Book\";
                fufile.SaveAs(path1 + "\\" + fufile.FileName);
                add_book.b_file = fufile.FileName.ToString();

                db.Add_Book.Add(add_book);
                db.SaveChanges();
               // return RedirectToAction("Index");
            }

            ViewBag.cid = new SelectList(db.Book_Category, "cid", "Category", add_book.cid);
            return View(add_book);
        }

    }
}