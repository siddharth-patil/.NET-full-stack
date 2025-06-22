using LINQ_to_SQL_Classes.Data_Access;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LINQ_to_SQL_Classes.Services
{
    public class EmployeeService
    {
        SqlConnection sqlcon;
        EmployeeDataContext dbContext_ref;

        public EmployeeService()
        {
            sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["ADODBConnectionString"].ConnectionString);
            dbContext_ref = new EmployeeDataContext(sqlcon);
        }

        public List<Emp> GetAll()
        {
            //return dbContext_ref.Emps.ToList();  //First way

            var result = (from emp in dbContext_ref.Emps
                         orderby emp.Gender ascending
                         select emp).ToList();

            return result;
        }

        public bool AddEmployee(Emp emp)
        {
            bool status = false;

            try
            {
                dbContext_ref.Emps.InsertOnSubmit(emp);
                dbContext_ref.SubmitChanges();
                status = true;
            }
            catch (Exception ex)
            {

            }

            return status;
        }

        public bool AddEmployeeWithProcedure(Emp emp)
        {
            bool status = false;

            try
            {
                dbContext_ref.CRUDEmployeeOperations(0,emp.Name, emp.Gender,emp.DateOfJoining, emp.Salary,"Add");
                dbContext_ref.SubmitChanges();
                status = true;
            }
            catch (Exception ex)
            {

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
                        dbContext_ref.Emps.InsertOnSubmit(emp);
                        break;
                    case "Delete":
                        Emp deletingEmp = dbContext_ref.Emps.FirstOrDefault(e=>e.Id == emp.Id);
                        if (deletingEmp != null)
                        {
                            //dbContext_ref.Emps.DeleteOnSubmit(emp);
                            dbContext_ref.CRUDEmployeeOperations(emp.Id, emp.Name, emp.Gender, emp.DateOfJoining, emp.Salary, operation);
                        }
                        break;
                    case "Update":
                        Emp existingEmp = dbContext_ref.Emps.FirstOrDefault(e=>e.Id == emp.Id);
                        if (existingEmp != null)
                        {
                            //existingEmp.Name = emp.Name;
                            //existingEmp.Gender = emp.Gender;
                            //existingEmp.DateOfJoining = emp.DateOfJoining;
                            //existingEmp.Salary = emp.Salary;

                            dbContext_ref.CRUDEmployeeOperations(emp.Id, emp.Name, emp.Gender, emp.DateOfJoining, emp.Salary, operation);
                        }
                        break;

                    default:
                        break;
                }
                //dbContext_ref.SubmitChanges();
                status = true;
            }
            catch (Exception)
            {
            }
           
            return status;
        }
    }
}