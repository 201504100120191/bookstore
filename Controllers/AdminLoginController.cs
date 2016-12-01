using Online_Book_Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Online_Book_Store.Controllers
{
    public class AdminLoginController : Controller
    {
        Context db = new Context();
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(AdminLogin a)
        {
            var data = from user in db.admin where user.username == a.username && user.password == a.password select user;
            if (data.Count() == 1)
            {
                Session["admin_name"] = a.username;
                return RedirectToAction("create", "AddBook");
            }
            else
            {
                Response.Write("Invalid username or password");
            }            

            return View();
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            Session.Clear();
            Session.RemoveAll();
            Session.Remove("admin_name");
            return RedirectToAction("Login");
        }

    }
}
