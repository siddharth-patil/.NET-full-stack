﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_FirstApp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation {  get; set; }    
        public double Salary { get; set; }
    }
}