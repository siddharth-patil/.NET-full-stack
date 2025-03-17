using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsDemo
{
    class Employee
    {
        int emp_id;
        string emp_name;
        string emp_gender;
        double emp_salary;

        public Employee() // Default Constructor
        {
            emp_id = 1000;
            emp_name = "ABC XYZ";
            emp_gender = "Not Known";
            emp_salary = 10000.5;
        }
        //public Employee(int Emp_id,string Emp_name,string Emp_gender,double Emp_salary)
        //{
        //    emp_id = Emp_id;
        //    emp_name = Emp_name;
        //    emp_gender = Emp_gender;
        //    emp_salary = Emp_salary;
        //}
        public Employee(int emp_id,string emp_name,string emp_gender,double emp_salary) // Parameterised Constructor
        {
            this.emp_id = emp_id;
            this.emp_name = emp_name;
            this.emp_gender = emp_gender;
            this.emp_salary = emp_salary;
        }

        public Employee(Employee emp_ref) // Copy Constructor
        {
            this.emp_id = emp_ref.emp_id;
            this.emp_name = emp_ref.emp_name;
            this.emp_gender = emp_ref.emp_gender;
            this.emp_salary = emp_ref.emp_salary;
        }
        public string Display()
        {
            return $"Employee Details \n Id:{this.emp_id} \n Name:{emp_name} \n Gender:{emp_gender} \n Salary:{emp_salary}";
        }

    }
}
