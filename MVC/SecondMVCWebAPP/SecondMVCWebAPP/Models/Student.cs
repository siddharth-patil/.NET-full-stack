using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecondMVCWebAPP.Models
{
    public class Student
    {
        public int Roll {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Qualification { get; set; }
        public string DateofBirth { get; set; }
        public double Percentage { get; set; }
    }
}