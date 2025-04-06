using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
    class GenericsPrincipleClass
    {
        public void SwapValues<T>(ref T x, ref T y)
        {

            Console.WriteLine($"x:{x.GetType()}   y:{y.GetType()}");

            T temp = x;
            x = y;
            y = temp;
        }
    }
}
