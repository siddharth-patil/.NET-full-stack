using EntityFrameworkDbFirst.Data_Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDbFirst.Service
{
    public class EmployeeService
    {
        ADODBEntities context_ref;

        public EmployeeService()
        {
            context_ref = new ADODBEntities();
        }

        public List<Emp> GetAll()
        {
            return context_ref.Emps.ToList();
        }

        public bool ManipulateData(Emp emp, string operation)
        {
            bool status = false;
            try
            {
                switch (operation)
                {
                    case "Add":
                        context_ref.Emps.Add(emp);
                        break;
                    case "Delete":
                        var existingEmp = context_ref.Emps.FirstOrDefault(x => x.Id == emp.Id);
                        if (existingEmp != null)
                        {
                            context_ref.Emps.Remove(existingEmp);
                        }
                        break;
                    case "Update":
                        var unEditedEmp = context_ref.Emps.FirstOrDefault(y => y.Id == emp.Id);
                        if (unEditedEmp != null) { 
                            unEditedEmp.Name = emp.Name;
                            unEditedEmp.Gender = emp.Gender;    
                            unEditedEmp.Salary = emp.Salary;
                            unEditedEmp.DateOfJoining = emp.DateOfJoining;
                        }
                        break;
                    default:
                        break;
                }
                status = true;
                context_ref.SaveChanges();
            }
            catch (Exception)
            {

            }    

            return status;
        }

    }


}
