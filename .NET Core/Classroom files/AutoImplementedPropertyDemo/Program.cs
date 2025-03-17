using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoImplementedPropertyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person_ref1 = new Person { FirstName = "Laura", LastName = "Acusta" };
            Console.WriteLine($"Person Fullname is:{person_ref1.FirstName}  {person_ref1.LastName}");
        }
    }
}
