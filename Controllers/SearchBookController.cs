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
    public class SearchBookController : Controller
    {
        private Context db = new Context();

       public ActionResult Index()
       {
           var display = db.Add_Book.ToList();
         
            //if (searchby="Title")
            //{
            //    return View(db.Add_BookToList().Where(x=>x.btitle.Contains(search)||search==null));
            //}

           return View(display);

             }

        public ActionResult Create()
        {
            return View(db.Add_Book.ToList());            
        }

        [HttpPost]
        public ActionResult Create(string S,string q,Add_Book add_book)
        {
            var search = from s in db.Add_Book select s;
            int id = Convert.ToInt32(Request["searchBy"]);
            //var dislay = db.Add_Book.Where(x => x.btitle.Contains(q) || x.author.Contains(q) || x.publication.Contains(q));
            //return View("Index",dislay);
            var searchParameter = "Searching";

            if (!string.IsNullOrWhiteSpace(q))
            {
                switch (id)
                {
                    case 0:
                       // int iQ = int.Parse(q);
                        search = search.Where(s => s.btitle.Contains(q));
                        searchParameter += " Book title for '" + q + "'";
                        return View("Index", search);

                    case 1:
                        search = search.Where(s => s.author.Contains(q));
                        searchParameter += " Book author for '" + q + "'";
                        return View("Index",search);

                    case 2:
                        search = search.Where(s => s.publication.Contains(q));
                        searchParameter += " Book publication for '" + q + "'";
                        return View("Index",search);
                }
            }
           else
           {
               searchParameter += "ALL";
           }
           ViewBag.SearchParameter = searchParameter;
           return View(search);

        //    if (ModelState.IsValid)
        //    {
        //        //ViewBag.search = db.Add_Book.Where(a => a.btitle == from["Search"].ToString());
        //        if (ViewBag.search!=null)
        //        {
        //            Response.Write("failed");
        //        }
        //        db.Add_Book.Add(add_book);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    ViewBag.cid = new SelectList(db.Book_Category, "cid", "Category", add_book.cid);
        //    return View(add_book);
        //}
    }}}
