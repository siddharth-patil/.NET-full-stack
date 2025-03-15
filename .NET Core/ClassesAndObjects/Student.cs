using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Student
    {
        int rollNo;
        string name;
        double percentage;

        public void GetInfo(int RollNo, string Name, double Percentage)
        {
            rollNo = RollNo;
            name = Name;
            percentage = Percentage;
        }

        public void displayInfo()
        {
            Console.WriteLine($"Student data:\n Roll Number:{rollNo}\n Name:{name}\n Percentage:{percentage}");
        }
    }
}
