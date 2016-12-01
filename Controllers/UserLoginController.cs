using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Online_Book_Store.Models;

namespace Online_Book_Store.Controllers
{
    public class UserLoginController : Controller
    {
       // private Online_Book_StoreContext db = new Online_Book_StoreContext();

        Context db = new Context();
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Registration r)
        {
            var data = from login in db.Registrations where login.email == r.email && login.password == r.password select login;
            if (data.Count() == 1)
            {
                Session["email"] = r.email;
                return RedirectToAction("Home","Home");
            }
            else
            {
                Response.Write("Incorrect username or password");
                // return RedirectToAction("Login");
            }    
            return View();
        }
        //private bool IsValid(string email, string password)
        //{
            
        //    return IsValid;
        //} 
    }
}
