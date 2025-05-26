using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadSynchronizationDemo
{
    class AccountUser
    {
        Account backAccount;
        Option withdrawOption;
        double amount;

        public AccountUser(Account backAccount, Option withdrawOption, double amount)
        {
            this.backAccount = backAccount;
            this.withdrawOption = withdrawOption;
            this.amount = amount;
        }

        public void Debit()
        {
             
        }
    }
}
