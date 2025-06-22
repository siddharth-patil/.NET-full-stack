using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessUsingConnectedArchitecrture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Employee> res = EmployeeOperations.GetAll();

            //foreach (Employee emp in res)
            //{
            //    Console.WriteLine(emp);
            //}

            EmployeeOperationsNew obj_ref = new EmployeeOperationsNew();
            List<Employee> res = obj_ref.GetAllEmployees();

            if (res.Count == 0)
            {
                Console.WriteLine("No data present in the table");
            }
            else
            {
                foreach (Employee emp in res)
                {
                    Console.WriteLine(emp);
                }
            }


            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Gender");
            string gender = Console.ReadLine();

            Console.WriteLine("Enter DoJ");
            string doj = Console.ReadLine();

            Console.WriteLine("Enter Salary");
            double salary = Convert.ToDouble(Console.ReadLine());


            if(obj_ref.ManipulateEmployee(new Employee { Name = name, Gender = gender, DateOfJoining = doj, Salary = salary}, "Add"))
            {
                Console.WriteLine("Record is inserted successfully..!");
            }
            else
            {
                Console.WriteLine("Record is not inserted successfully..!");
            }


            res = obj_ref.GetAllEmployees();

            if (res.Count == 0)
            {
                Console.WriteLine("No data present in the table");
            }
            else
            {
                foreach (Employee emp in res)
                {
                    Console.WriteLine(emp);
                }
            }

        }
    }
}
