using EntityFrameworkDatabaseFirstDemo.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDatabaseFirstDemo.Service
{
    public class EmployeeService
    {
        Entities context_ref;
        public EmployeeService()
        {
             context_ref = new Entities();
        }
        public List<Employee> GetAll()
        {
            return context_ref.Employees.ToList();
        }

        public bool ManipulateData(Employee emp,string Operation)
        {
            bool status = false;
            try
            {
                switch (Operation)
                {
                    case "Add":
                        context_ref.Employees.Add(emp);
                        break;
                    case "Delete":
                        var existingEmployee = context_ref.Employees.FirstOrDefault(x => x.Id == emp.Id);
                        if (existingEmployee != null)
                        {
                            context_ref.Employees.Remove(existingEmployee);

                        }
                        break;
                    case "Update":
                        var unEditedEmployee = context_ref.Employees.FirstOrDefault(y => y.Id == emp.Id);
                        if (unEditedEmployee!=null)
                        {
                            unEditedEmployee.Name = emp.Name;
                            unEditedEmployee.Gender = emp.Gender;
                            unEditedEmployee.DateofJoining = emp.DateofJoining;
                            unEditedEmployee.Salary = emp.Salary;
                        }
                        break;
                    
                    default:
                        break;
                }
                status = true;
                context_ref.SaveChanges();


               
            }
            catch (Exception ex)
            {

            }

            return status;
                    
            }
          
        }
   
}
