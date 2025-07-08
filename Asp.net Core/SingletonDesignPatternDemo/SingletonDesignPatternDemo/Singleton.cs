using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPatternDemo
{
    public sealed class Singleton
    {
        static Singleton singleton_ref;
        static int count = 0;
        private Singleton() 
        {
            count++;
            Console.WriteLine(count);
        }
        static Singleton()
        {
            singleton_ref = new Singleton();
        }

        public static Singleton getInstance
        {
            get
            {
                return singleton_ref;
            }
        }

        public void Get(string sts)
        {
            Console.WriteLine(sts);
        }
    }
}
