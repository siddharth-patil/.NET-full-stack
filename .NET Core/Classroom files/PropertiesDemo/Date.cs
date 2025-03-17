using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesDemo
{
    class Date
    {
        int day;

        public int Day
        {
            get
            {
                return day;
            }
            set
            {
                day = value;
            }
        }

        string month;
        public string Month
        {
            get
            {
                return month;
            }
            set
            {
                month = value;
            }
        }
        int year;
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }

        public string Display()
        {
            return $"{day}/{month}/{year}"; 
        }

    }
}
