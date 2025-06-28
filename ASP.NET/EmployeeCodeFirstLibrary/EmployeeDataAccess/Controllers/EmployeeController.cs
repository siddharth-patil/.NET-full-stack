using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeCodeFirstLibrary;
using EmployeeCodeFirstLibrary.Model;
using EmployeeCodeFirstLibrary.Services;

namespace EmployeeDataAccess.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeService service_ref;
        public EmployeeController()
        {
            service_ref = new EmployeeService();
        }
        // GET: Employee
        public ActionResult Index()
        {
            return View(service_ref.GetAll());
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            return View(service_ref.GetById(id));
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(EmployeeMVC employee)
        {
            try
            {
                // TODO: Add insert logic here
                if (service_ref.ManipulateEmployee(employee, "Add"))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(employee);
                }
                    
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            EmployeeMVC employee = service_ref.GetById(id);
            return View(employee);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(EmployeeMVC employee)
        {
            try
            {
                // TODO: Add update logic here
                if (service_ref.ManipulateEmployee(employee, "Update"))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(employee);
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            EmployeeMVC employee = service_ref.GetById(id);
            return View(employee);
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(EmployeeMVC employee)
        {
            try
            {
                // TODO: Add delete logic here
                if (service_ref.ManipulateEmployee(employee, "Delete"))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(employee);
                }
            }
            catch
            {
                return View();
            }
        }
    }
}
