using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericsClass ref1 = new GenericsClass();
            int no1 = 10, no2 = 20;

            Console.WriteLine($" Integer Input values are:{no1} {no2}");

            if (ref1.CompareValues(no1,no2))
            {
                Console.WriteLine($"{no1} is greater than {no2}" );
            }
            else
            {
                Console.WriteLine($"{no2} is greater than {no1}");
            }


           
            ref1.SwapValues(ref no1, ref no2);

            Console.WriteLine($"Swapped values are:{no1} {no2}");

            // For String Data Type

            string str1 = "Sara Jones", str2 = "Simon Venables";

            Console.WriteLine($" String Input values are:{str1} {str2}");

            if (ref1.CompareValues(str1, str2))
            {
                Console.WriteLine($"{str1} is greater than {str2}");
            }
            else
            {
                Console.WriteLine($"{str2} is greater than {str1}");
            }



            ref1.SwapValues(ref str1, ref str2);

            Console.WriteLine($"Swapped values are:{str1} {str2}");


        }
    }
}
