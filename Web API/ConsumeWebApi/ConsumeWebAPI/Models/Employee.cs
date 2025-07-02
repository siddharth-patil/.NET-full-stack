﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsumeWebAPI.Models
{
    public class Employee
    {
        public int Id {  get; set; }

        public string Name { get; set; }

        public string Gender {  get; set; }

        public string DateOfJoining {  get; set; }

        public double Salary {  get; set; }
    }
}