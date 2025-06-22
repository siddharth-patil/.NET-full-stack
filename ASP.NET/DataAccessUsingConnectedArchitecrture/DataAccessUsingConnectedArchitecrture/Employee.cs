using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessUsingConnectedArchitecrture
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        public string DateOfJoining { get; set; }
        //public DateTime DateOfJoining { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"{Id}   {Name}   {Gender}   {Salary}   {DateOfJoining}";
        }
    }
}
