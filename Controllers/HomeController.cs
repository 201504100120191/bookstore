using Online_Book_Store.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Online_Book_Store.Controllers
{
    public class HomeController : Controller
    {

        Context db = new Context();

        public ActionResult Index()
        {
            return View(db.Add_Book.ToList());            
        }

        public ActionResult Home()
        {
            return View();
        }
        public ActionResult MainHome()
        {
            return View();
        }
    }
}
