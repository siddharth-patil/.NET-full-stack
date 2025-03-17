using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Constructors Demo");
            //Employee employee_ref1 = new Employee();  // Default Constructor
            //Console.WriteLine(employee_ref1.Display());

            Employee employee_ref2 = new Employee(0032, "Steve Austin", "Male", 105000.5); // Parameterised constructor
            Console.WriteLine(employee_ref2.Display());

            Employee employee_ref3 = new Employee(employee_ref2);
            Console.WriteLine(employee_ref3.Display());

            //Employee emp_ref4 = new Employee { emp_id = 267, emp_name = "Sara Jones", emp_gender = "Female", emp_salary=95000.5 };
            
            Console.ReadKey();
        }
    }
}
