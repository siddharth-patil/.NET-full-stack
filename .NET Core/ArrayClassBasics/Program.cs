using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = new int[] { 1, 4, 6, 2, 5, 3, 9, 7, 0, 8 };

            Console.WriteLine("Original array is:");
            foreach (int item in Arr)
            {
                Console.Write($"\t{item}");
            }

            //Sort the array
            Array.Sort(Arr);
            //Array.Sort(Arr, 0, 5);

            Console.WriteLine("\nSorted array in ascending order is:");
            foreach (int item in Arr)
            {
                Console.Write($"\t{item}");
            }

            // Reverse the order of current Array Elements

            Array.Reverse(Arr);
            Console.WriteLine("\nSorted array in descending order is:");
            foreach (int item in Arr)
            {
                Console.Write($"\t{item}");
            }

            // Copy Array elements into newly created array

            //int[] CopyArr = new int[Arr.Length];

            //Array.Copy(Arr, CopyArr, Arr.Length);

            //Console.WriteLine("\nCopied array is:");
            //foreach (int item in CopyArr)
            //{
            //    Console.Write($"\t{item}");
            //}


            // Binary Search
            //Console.WriteLine("\nEnter the value to search");
            //int val = Convert.ToInt32(Console.ReadLine());

            //int returnValue = Array.BinarySearch(Arr, val);

            //if (returnValue > 0)
            //{
            //    Console.WriteLine($"The value {val} found and it is present at index :{returnValue}");
            //}
            //else
            //{
            //    Console.WriteLine($"The value {val} not found");
            //    Console.WriteLine(returnValue);
            //}
        }
    }
}
