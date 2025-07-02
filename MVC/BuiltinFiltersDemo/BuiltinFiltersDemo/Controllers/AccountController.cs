using BuiltinFiltersDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BuiltinFiltersDemo.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserDetails user, string ReturnUrl)
        {
            if (ValidateUser(user.Name, user.Passowrd))
            {
                FormsAuthentication.SetAuthCookie(user.Name,false);
                return Redirect(ReturnUrl);
            }
            else 
            { 
                return View(user);
            }

        }

        bool ValidateUser(string username, string password)
        {
            return (username == "Sid" && password == "sid@123") ? true : false;

            //if (username =="Sid" && password=="sid@123")
            //{
            //    return true;
            //}
            //return false;
        }
    }
}