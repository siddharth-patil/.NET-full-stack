using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StateManagementTechniquesDemo.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            HttpCookie cookie = Request.Cookies["info"];
            if (cookie != null) {
                return $"Received Cookie values are : {cookie["time"]} <br> {cookie["fruits"]}";
            }
            else
            {
                return "No values received!!!";
            }
        }

        public ActionResult About()
        {
            HttpCookie cookie = new HttpCookie("info");

            cookie["time"] = $"This cookie is created at {DateTime.Now}";
            List<string> fruits = new List<string> { "Mango","Apple","Guava","strawberry","banana"};

            foreach (var fruit in fruits)
            {
                cookie["fruits"] = $"{cookie["fruits"]}  {fruit}";
            }

            Response.Cookies.Add(cookie);

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}