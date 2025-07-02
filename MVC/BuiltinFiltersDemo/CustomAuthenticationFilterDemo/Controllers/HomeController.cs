using CustomAuthenticationFilterDemo.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomAuthenticationFilterDemo.Controllers
{
    public class HomeController : Controller
    {
        UserService service_ref;

        public HomeController()
        {
            service_ref = new UserService();
        }
        public ActionResult Index()
        {
            return View(service_ref.GetUsers());
        }

        [CustomAuthentication]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}