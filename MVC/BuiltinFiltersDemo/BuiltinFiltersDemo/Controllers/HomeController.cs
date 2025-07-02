using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BuiltinFiltersDemo.Controllers
{
    public class HomeController : Controller
    {
        //[OutputCache(Duration = 10)]
        public ActionResult Index()
        {
            ViewBag.Time = DateTime.Now.ToString("T"); 

            return View();
        }

        [HttpPost]
        //[ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult Index(string txtInput)
        {
            ViewBag.Text = txtInput;

            return View();
        }

        [Authorize]
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