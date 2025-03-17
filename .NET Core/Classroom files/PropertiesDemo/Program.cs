using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Date date_ref1 = new Date { Day = 10, Month = "Oct", Year = 2024};
            //Console.WriteLine(date_ref1.Display());

            Console.WriteLine($"The date is:{date_ref1.Day}/{date_ref1.Month}/{date_ref1.Year}");
        }
    }
}
