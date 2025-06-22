using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_FirstApp.Controllers
{
    public class FruitController : Controller
    {
        // GET: Fruit
        public ViewResult Index()
        {
            List<string> FruitNames = new List<string> {
                "Mango", "Banana", "Apple", "Guava"
            };

            Session["Fruits"] = FruitNames;

            return View();
        }
    }
}