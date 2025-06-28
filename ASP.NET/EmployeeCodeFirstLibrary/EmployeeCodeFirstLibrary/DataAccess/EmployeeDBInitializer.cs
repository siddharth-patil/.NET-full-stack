using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EmployeeCodeFirstLibrary.Model;

namespace EmployeeCodeFirstLibrary.DataAccess
{
    public class EmployeeDBInitializer:DropCreateDatabaseIfModelChanges<EmployeeDbContext>
    {
        protected override void Seed(EmployeeDbContext context)
        {
            List<EmployeeMVC> employees = new List<EmployeeMVC>
            {
                new EmployeeMVC {EmpId = 1001, FirstName = "Anand", LastName = "Vishwanathan", Gender ="Male", Designation = "SDE-5", Email = "vishy@gmail.com", Age= 53, Salary=99000.5},
                new EmployeeMVC {EmpId = 1002, FirstName = "Gukesh", LastName = "Dommaraju", Gender ="Male", Designation = "SDE-3", Email = "gukesh@gmail.com", Age= 19, Salary=75000.5},
                new EmployeeMVC {EmpId = 1003, FirstName = "Vidit", LastName = "Gujarathi", Gender ="Male", Designation = "SDE-2", Email = "vidit@gmail.com", Age= 29, Salary=70000.5}
            };

            employees.ForEach(emp=>context.Employees.Add(emp));
            context.SaveChanges();
        }
    }
}
