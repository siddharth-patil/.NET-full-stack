using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterisedThreadStartDemo
{
    class Math
    {
        public void printNum(object length)
        {
            for (int i = 0; i <(int)length;i++) {
                Console.WriteLine(i);
            }
        }

        
    }
}
