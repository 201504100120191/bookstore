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
    public class FeedbackController : Controller
    {
        Context db = new Context();

        public ActionResult Create()
        {
            return View();
        }
 

        [HttpPost]
        public ActionResult Create(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                db.Feedbacks.Add(feedback);
                db.SaveChanges();
              //  return RedirectToAction("Index");
            }

            return View(feedback);
        }
    }
}