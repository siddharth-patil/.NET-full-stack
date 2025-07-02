using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Models;

namespace WebAPI.Services
{
    public class EmployeeService
    {
        EmployeeDataContext dbcontext_ref;
        public EmployeeService()
        {
            dbcontext_ref = new EmployeeDataContext();  
        }

        public List<Emp> GetAll()
        {
            return dbcontext_ref.Emps.ToList();
        }

        public Emp GetById(int id)
        {
            return dbcontext_ref.Emps.FirstOrDefault(e=>e.Id == id);
        }

        public bool ManipulateEmployee(Emp emp, string methodName)
        {
            bool status = false;

            try
            {
                switch (methodName)
                {
                    case "Add":
                        dbcontext_ref.Emps.InsertOnSubmit(emp);
                        break;
                    case "Update":
                        var existingEmp = dbcontext_ref.Emps.FirstOrDefault(e=>e.Id == emp.Id);
                        if (existingEmp!=null)
                        {
                            existingEmp.Name = emp.Name;
                            existingEmp.Gender = emp.Gender;
                            existingEmp.Salary = emp.Salary;
                            existingEmp.DateOfJoining = emp.DateOfJoining;
                        }
                        break;
                    case "Delete":
                        existingEmp = dbcontext_ref.Emps.FirstOrDefault(e => e.Id == emp.Id);
                        if (existingEmp != null)
                        {
                            dbcontext_ref.Emps.DeleteOnSubmit(existingEmp);
                        }
                        break;
                            default:
                        break;
                }
                status = true;
                dbcontext_ref.SubmitChanges();
            }
            catch (Exception)
            {

                throw;
            }

            return status;
        }
    }
}