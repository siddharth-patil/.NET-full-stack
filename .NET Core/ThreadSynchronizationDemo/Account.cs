using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadSynchronizationDemo
{
    enum Option
    {
        ATM,
        WithDraw,
        Check
    }
    class Account
    {
        public int acc_no { get; set; }
        public string Name { get; set; }

        public double Balance { get; set; }

        public string withDraw(double amount)
        {
            if (Balance>amount)
            {
                Balance -= amount;
                return $"The amount {amount}";
            }
            else
            { 
                return $"The amount {amount}"; 
            }
        }
    }
}
