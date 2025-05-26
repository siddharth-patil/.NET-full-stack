using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGenericClassDemo
{
    class GenericClass<SP>
    {
        SP[] Arr;

        public GenericClass(int size) 
        {
            Arr = new SP[size];
        }

        public SP[] Display()
            { return Arr; }

        public void Accept(SP[] Arr)
        {
            this.Arr = Arr;
        }
    }
}
