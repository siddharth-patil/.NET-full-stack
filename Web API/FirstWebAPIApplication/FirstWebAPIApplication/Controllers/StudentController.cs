using FirstWebAPIApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FirstWebAPIApplication.Controllers
{
    public class StudentController : ApiController
    {

        List<Student> students;

        public StudentController()
        {
            students = new List<Student>
            {
                new Student{Roll = 1, Name = "Steve Austin", Gender = "Male", Marks = 65.45},
                new Student{Roll = 2, Name = "Sara Jones", Gender = "Female", Marks = 75.95},
                new Student{Roll = 3, Name = "Davide Lovera", Gender = "Male", Marks = 85.45},
                new Student{Roll = 4, Name = "Don Vens", Gender = "Female", Marks = 55.45},
            };
        }
        // GET: api/Student
        public List<Student> Get()
        {
            return students;
        }

        // GET: api/Student/5
        public Student Get(int id)
        {
            return students.FirstOrDefault(s=>s.Roll == id);
        }

        // POST: api/Student
        public void Post([FromBody]Student newStudent)
        {
            students.Add(newStudent);
        }

        // PUT: api/Student/5
        public void Put(int id, [FromBody]Student changedStudent)
        {
            Student existing = students.Find(s=>s.Roll==changedStudent.Roll); 

            existing.Name = changedStudent.Name;
            existing.Marks = changedStudent.Marks;
            existing.Gender = changedStudent.Gender;


        }

        // DELETE: api/Student/5
        public void Delete(int id)
        {
            Student existing = students.Find(s=>s.Roll==id);
            students.Remove(existing);
        }
    }
}
