using MVCAppWithLinqToSql.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace MVCAppWithLinqToSql.Service
{
    public class EmployeeOperations
    {
        EmployeeDataContext context_ref;

        public EmployeeOperations()
        {
            context_ref = new EmployeeDataContext(ConfigurationManager.ConnectionStrings["ADODBConnectionString"].ConnectionString);
        }

        public List<Emp> GetAll()
        {
            var result = (from emp in context_ref.Emps
                         orderby emp.Salary descending
                         select emp).ToList();

            return result;
        }

        public Emp GetEmp(int id)  //Get employee by id
        {
            //var result = from emp in context_ref.Emps
            //             where emp.Id == id
            //             select emp;

            var result = context_ref.Emps.FirstOrDefault(e => e.Id == id);

            return result;
        }

        public bool EditEmployee(Emp editedEmp)
        {
            bool status = false;

            try
            {
                var existingEmp = context_ref.Emps.FirstOrDefault(e => e.Id == editedEmp.Id);
                if (existingEmp != null)
                {
                    existingEmp.Salary = editedEmp.Salary;
                    existingEmp.Name = editedEmp.Name;
                    existingEmp.Gender = editedEmp.Gender;
                    existingEmp.DateOfJoining = editedEmp.DateOfJoining;

                    context_ref.SubmitChanges();

                    status = true;
                }
                
            }
            catch (Exception)
            {

                throw;
            }

            return status;
        }

        public bool ManipulateEmp(Emp emp, string operation)
        {
            bool status = false;

            try
            {
                switch (operation)
                {
                    case "Add":
                        context_ref.Emps.InsertOnSubmit(emp);
                        break;
                    case "Edit":
                        context_ref.CRUDEmployeeOperations(emp.Id,emp.Name,emp.Gender,emp.DateOfJoining,emp.Salary,"Update");
                        break;
                    case "Delete":
                        context_ref.Emps.DeleteOnSubmit(emp);
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