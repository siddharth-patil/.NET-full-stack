using SecondMVCWebAPP.DataAccess;
using SecondMVCWebAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecondMVCWebAPP.Controllers
{
    public class StudentController : Controller
    {

        StudentService studentService;

        public StudentController()
        {
            studentService = new StudentService();
        }
        // GET: Student
        public ActionResult Index()
        {
            List<Student> res = studentService.GetAll();
            //Session["List"] = res;
            return View(res);
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View(studentService.GetById(id));
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(Student newstudent)
        {
            try
            {
                // TODO: Add insert logic here
                if (studentService.AddNew(newstudent))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(newstudent);
                }

            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            Student existingStudent = studentService.GetById(id);
            return View(existingStudent);
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(Student editedStudent)
        {
            try
            {
                // TODO: Add update logic here
                if (studentService.EditStudent(editedStudent))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }

                
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            Student dltStudent = studentService.GetById(id);
            return View(dltStudent);
        }

        // POST: Student/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteStudent(int roll)
        {
            try
            {
                // TODO: Add delete logic here
                if (studentService.deleteStudent(roll))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }

                
            }
            catch
            {
                return View();
            }
        }
    }
}
