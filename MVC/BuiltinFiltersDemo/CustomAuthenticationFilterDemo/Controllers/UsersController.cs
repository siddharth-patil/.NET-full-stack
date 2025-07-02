using CustomAuthenticationFilterDemo.DataAccess;
using CustomAuthenticationFilterDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace CustomAuthenticationFilterDemo.Controllers
{
    public class UsersController : Controller
    {
        UserService service_ref;
        public UsersController()
        {
            service_ref = new UserService();
        }
        // GET: Users
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserDetails enteredData, string RedirectUrl)
        {
            if (service_ref.AuthenticateUser(enteredData))
            {
                FormsAuthentication.SetAuthCookie(enteredData.Name, false);
                return Redirect("/Home/About");
            }
            else
            {
                return View();
            }
        }

        public ActionResult GetAll()
        {
            return View(service_ref.GetUsers());    
        }
    }
}