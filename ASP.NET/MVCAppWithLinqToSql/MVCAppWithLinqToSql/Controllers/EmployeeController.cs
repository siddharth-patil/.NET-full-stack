using MVCAppWithLinqToSql.Models;
using MVCAppWithLinqToSql.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAppWithLinqToSql.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeOperations service_ref;
        public EmployeeController()
        {
            service_ref = new EmployeeOperations();
        }
        // GET: Employee
        public ActionResult Index()
        {
            return View(service_ref.GetAll());
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
        public ActionResult Create(Emp newEmployee)
        {
            try
            {
                // TODO: Add insert logic here
                if (service_ref.ManipulateEmp(newEmployee,"Add"))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(newEmployee);
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
            var EmpObj = service_ref.GetEmp(id);

            return View(EmpObj);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(Emp emp)
        {
            try
            {
                // TODO: Add update logic here
                //if (service_ref.EditEmployee(emp))
                if (service_ref.ManipulateEmp(emp,"Edit"))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(emp) ;
                }

                
            }
            catch
            {
                return View(emp);
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteEmp(int id)
        {
            var emp = service_ref.GetEmp(id);
            try
            {
                // TODO: Add Delete logic here

                if (service_ref.ManipulateEmp(emp, "Delete"))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(emp);
                }


            }
            catch
            {
                return View(emp);
            }
        }
    }
}
