using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    class Program1
    {
        static void Main(string[] args)
        {
            GenericsPrincipleClass ref1 = new GenericsPrincipleClass();
            // Integer Data Type
            int x = 10, y = 20;
            Console.WriteLine($"\nOriginal input values are:{x} {y}");
            ref1.SwapValues<int>(ref x, ref y);
            Console.WriteLine($"Swapped input values are:{x} {y}");

            // String Data Type
            string str1 = "ABC", str2 = "XYZ";
            Console.WriteLine($"\nOriginal input values are:{str1} {str2}");
            ref1.SwapValues<string>(ref str1, ref str2);
            Console.WriteLine($"Swapped input values are:{str1} {str2}");

            // Person Data Type
            Person p1 = new Person { FirstName = "Steve", LastName="Austin" };
            Person p2 = new Person { FirstName = "Sara", LastName = "Jones" };
            Console.WriteLine($"\nOriginal input values are:{p1} {p2}");
            ref1.SwapValues<Person>(ref p1, ref p2);
            Console.WriteLine($"Swapped input values are:{p1} {p2}");


           
        }
    }
}
