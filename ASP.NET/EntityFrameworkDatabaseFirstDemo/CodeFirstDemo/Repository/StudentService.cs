using CodeFirstDemo.DataAccess;
using CodeFirstDemo.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo.Repository
{
    public class StudentService
    {
        StudentDbContext dbContext_ref;
        public StudentService() 
        { 
            dbContext_ref = new StudentDbContext();
        }
        public List<StudentDetails> GetAll()
        {
             return dbContext_ref.Students.ToList();
        }

        public bool ManipulateData(StudentDetails student,string Operation)
        {
            bool status = false;
            try
            {
                switch (Operation)
                {
                    case "Add":
                        dbContext_ref.Students.Add(student);
                        break;
                    case "Delete":
                        var existingStudent = dbContext_ref.Students.FirstOrDefault(st => st.Roll == student.Roll);
                        if (existingStudent!=null)
                        {
                            dbContext_ref.Students.Remove(existingStudent);
                        }
                        break;
                    case "Update":
                        var unUpdatedStudent = dbContext_ref.Students.FirstOrDefault(st => st.Roll == student.Roll);
                        if (unUpdatedStudent!=null)
                        {
                            unUpdatedStudent.FirstName = student.FirstName;
                            unUpdatedStudent.LastName = student.LastName;
                            unUpdatedStudent.Gender= student.Gender;
                            unUpdatedStudent.DateofBirth= student.DateofBirth;
                            unUpdatedStudent.Email= student.Email;
                            unUpdatedStudent.Qualification= student.Qualification;
                            unUpdatedStudent.Percentage = student.Percentage;
                        }
                        break;
                    default:
                        break;
                }
                dbContext_ref.SaveChanges();
                
                status = true;
            }
            catch (Exception ex)
            {

            }


            return status;
        }

    }
}
