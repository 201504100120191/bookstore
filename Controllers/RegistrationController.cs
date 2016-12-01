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
    public class RegistrationController : Controller
    {
        private Online_Book_StoreContext db = new Online_Book_StoreContext();

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Registration registration)
        {
            if (ModelState.IsValid)
            {
                db.Registrations.Add(registration);
                db.SaveChanges();
            }

            return View(registration);
        }
    }
}