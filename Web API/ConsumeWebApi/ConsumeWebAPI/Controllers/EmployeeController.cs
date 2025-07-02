using ConsumeWebAPI.Models;
using ConsumeWebAPI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConsumeWebAPI.Controllers
{
    public class EmployeeController : Controller
    {
        ConsumeWebApi api_ref;
        public EmployeeController()
        {
            api_ref = new ConsumeWebApi();
        }
        // GET: Employee
        public ActionResult Index()
        {
            List<Employee> employees = api_ref.ConsumeAll();
            return View(employees);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            try
            {
                // TODO: Add insert logic here
                if (api_ref.AddNewEmployee(employee))
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
            Employee emp = api_ref.GetById(id);
            return View(emp);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(Employee editedEmployee)
        {
            try
            {
                // TODO: Add update logic here
                if (api_ref.EditEmployee(editedEmployee))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(editedEmployee);
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
            Employee emp=api_ref.GetById(id);
            return View(emp);
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(Employee deletedEmployee)
        {
            try
            {
                // TODO: Add delete logic here
                if (api_ref.DeleteEmployee(deletedEmployee.Id))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(deletedEmployee);
                }
                
            }
            catch
            {
                return View();
            }
        }
    }
}
