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
    public class ShowFeedbackController : Controller
    {
        private Context db = new Context();

        public ActionResult Index()
        {
            return View(db.Feedbacks.ToList());
        }

    }
}