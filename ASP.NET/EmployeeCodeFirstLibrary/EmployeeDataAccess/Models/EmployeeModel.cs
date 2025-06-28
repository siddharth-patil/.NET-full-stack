using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeDataAccess.Models
{
    public class EmployeeModel
    {
        public int EmpId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

        public string Designation { get; set; }

        public string Email { get; set; }

        public int Age { get; set; }

        public double Salary { get; set; }
    }
}