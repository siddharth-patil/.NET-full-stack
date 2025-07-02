using DataAccessWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccessWebAPI.Services
{
    public class EmployeeService
    {
        EmployeeModelDataContext context_ref;
        public EmployeeService()
        {
            context_ref = new EmployeeModelDataContext();
        }

        public List<Emp> GetAll()
        {
            return context_ref.Emps.ToList();
        }

        public Emp GetById(int id)
        {
            return context_ref.Emps.FirstOrDefault(e => e.Id == id);
        }

        public bool ManipulateEmployeeData(Emp emp, string operation)
        {
            bool status = false;

            try
            {
                var existingEmp = context_ref.Emps.FirstOrDefault(e => e.Id == emp.Id);
                switch (operation)
                {
                    case "Add":
                        context_ref.Emps.InsertOnSubmit(emp);
                        break;
                    case "Update":
                        if (existingEmp != null)
                        {
                            existingEmp.Name = emp.Name;
                            existingEmp.Gender = emp.Gender;
                            existingEmp.DateOfJoining = emp.DateOfJoining;
                            existingEmp.Salary = emp.Salary;
                        }
                        break;
                    case "Delete":
                        if (existingEmp != null)
                        {
                            context_ref.Emps.DeleteOnSubmit(existingEmp);
                        }
                        break;
                    default:
                        break;
                }
                context_ref.SubmitChanges();
                status = true;
            }
            catch (Exception)
            {

            }


            return status;

        }
    }
}