using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDemo
{
    class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public double Percentage { get; set; }
        public override string ToString()
        {
            return $"\n{RollNo} {Name} {Percentage}";
        }
    }
}
