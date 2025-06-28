using EmployeeCodeFirstLibrary.DataAccess;
using EmployeeCodeFirstLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCodeFirstLibrary.Services
{
    public class EmployeeService
    {
        EmployeeDbContext context_ref;

        public EmployeeService()
        {
            context_ref = new EmployeeDbContext();
        }

        public List<EmployeeMVC> GetAll()
        {
            return context_ref.Employees.ToList();
        }

        public EmployeeMVC GetById(int id)
        {
            EmployeeMVC searchedEmployee = context_ref.Employees.FirstOrDefault(e=>e.EmpId == id);
            return searchedEmployee;
        }

        public bool ManipulateEmployee(EmployeeMVC emp, string operation)
        {
            bool status=false;
            try
            {
                EmployeeMVC searchedEmp = GetById(emp.EmpId);
                switch (operation)
                {
                    case "Add":
                        context_ref.Employees.Add(emp);
                        break;
                    case "Delete":
                        if (searchedEmp != null)
                        {
                            context_ref.Employees.Remove(searchedEmp);
                        }
                        break;
                    case "Update":
                        if (searchedEmp != null)
                        {
                            searchedEmp.FirstName = emp.FirstName;
                            searchedEmp.LastName = emp.LastName;
                            searchedEmp.Email = emp.Email;
                            searchedEmp.Gender = emp.Gender;
                            searchedEmp.Designation = emp.Designation;
                            searchedEmp.Age = emp.Age;
                            searchedEmp.Salary = emp.Salary;
                        }
                            break;
                    default:
                        break;
                }
                context_ref.SaveChanges();
                status = true;
            }
            catch (Exception ex) 
            {
            
            }

            return status;
        }
    }
}
