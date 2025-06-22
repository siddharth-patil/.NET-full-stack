using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoDotNet_ConnArch_Feature.Model
{
    public class Student
    {
        public int Roll { get; set; }
        public string Name { get; set; }
        public double Percentage { get; set; }


        public override string ToString()
        {
            return $"{Roll}   {Name}   {Percentage}";
        }
    }
}
