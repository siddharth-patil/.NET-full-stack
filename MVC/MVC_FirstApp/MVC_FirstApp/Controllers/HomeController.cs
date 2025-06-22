using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_FirstApp.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "In HomeController's Index Action";

            //List<string> FruitNames = new List<string> {
            //    "Mango", "Banana", "Apple", "Guava"
            //};

            //return FruitNames;
        }

        public string About()
        {
           
            return "In HomeController's About Action";
        }

        public string Contact()
        {
            
            return "In HomeController's Contact Action";
        }
    }
}