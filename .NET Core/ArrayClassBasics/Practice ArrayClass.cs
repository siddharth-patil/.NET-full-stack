using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayClassBasics
{
    static class Practice_ArrayClass
    {
        static int[] Arr1 = new int[] {2,4,32,1,6,2,7,3,7,78};

        public static void print()
        {
            Console.WriteLine("Original array");
            foreach (int item in Arr1)
            {
                Console.WriteLine($"{item}");
            }


            Array.Sort( Arr1 );
            //Console.WriteLine("sorted array");
            //foreach (int item in Arr1)
            //{
            //    Console.WriteLine($"{item}");
            //}

            //Array.Sort(Arr1, 2, 5);
            //Console.WriteLine("Half sorted array");
            //foreach (int item in Arr1)
            //{
            //    Console.WriteLine($"{item}");
            //}

            //Binary search
            Console.WriteLine("Enter a value to search");
            int val = Convert.ToInt32(Console.ReadLine());

            int returnValue = Array.BinarySearch(Arr1, val);

            if (returnValue >= 0)
            {
                Console.WriteLine($"The {val} found and it is present at index: {returnValue}");
            }
            else
            {
                Console.WriteLine("value not found");
                Console.WriteLine(returnValue);
            }

        }
    }
        
}
