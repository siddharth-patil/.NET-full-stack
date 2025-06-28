using StateManagementTechniquesDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StateManagementTechniquesDemo.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee {Id = 1001, Name = "PV Sindhu", Salary = 90000.9},
                new Employee {Id = 1002, Name = "Saina Nehwal", Salary = 70000.9},
                new Employee {Id = 1003, Name = "Niraj Chopra", Salary = 150000.9},
                new Employee {Id = 1004, Name = "Usha Patel", Salary = 80000.9},
            };

            //ViewData["EmpList"] = employees;

            //ViewBag.EmpList = employees;

            //TempData["EmpList"] = employees;
            //TempData.Keep();
            Session["EmpList"] = employees;
              
            return View();
        }

        public ActionResult About()
        {
            List<Employee> empList = new List<Employee>();

            //empList = ViewBag.EmpList; // it will be null as ViewBag data lifetime is only controller action to view. After using it for one time it will get vanished

            //empList = (List<Employee>)TempData["EmpList"];

            empList = (List<Employee>)Session["EmpList"];

            return View();
        }
    }
}