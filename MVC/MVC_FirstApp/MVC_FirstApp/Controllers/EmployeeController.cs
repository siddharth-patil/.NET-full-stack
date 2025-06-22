using MVC_FirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_FirstApp.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ViewResult Index()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee{Id= 1, Name="Siddharth Patil", Designation="Software Dev3", Salary=2000000},
                new Employee{Id= 1, Name="Ram Suryawanshi", Designation="Lead", Salary=20000000},
                new Employee{Id= 1, Name="Sham Bhau", Designation="Software Dev1", Salary=200000},
                new Employee{Id= 1, Name="Bhau Patil", Designation="Software Dev2", Salary=1200000},
            };
            Session["employees"] = employees;
            return View();
        }
    }
}