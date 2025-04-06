using System;
using System.Collections;

namespace Need_of_Generic_Collection_Classes
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return FirstName + " "+LastName;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 10;
            //object y = x;
            ////string s = x;


            //Console.WriteLine($"x={x}  y={y}");

            //object x = 10;
            //int no = (int)x;

            //Console.WriteLine($"x={x} no={no}");

            ArrayList a1 = new ArrayList();
            a1.Add(10);
            a1.Add(1.5f);
            a1.Add(123456.78901);
            a1.Add('#');
            a1.Add("Non Generic Collections");
            a1.Add(new Person { FirstName = "Steve", LastName = "Austin" });

            foreach (object item in a1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("The type of each element is:");
            foreach (var item in a1)
            {
                Console.WriteLine(item.GetType());
            }

        }
    }
}
