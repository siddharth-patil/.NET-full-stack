using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    class GenericsClass
    {
        public bool CompareValues(int x , int y)
        {
            return x.Equals(y) ? true : false;
        }


        public bool CompareValues(string x, string y)
        {
            return x.Equals(y) ? true : false;
        }


        public void SwapValues(ref int x,ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public void SwapValues(ref string x,ref string y)
        {
            string temp = x;
            x = y;
            y = temp;
        }

    }
}
