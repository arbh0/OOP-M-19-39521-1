using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class OverDraft : Account
    {
        double limit = 50000;
        public OverDraft() { }
        public OverDraft(string acName, string acId, double balance) : base(acName, acId, balance)
        {
            base.Balance = balance + limit;
        }
        new public void Deposit(double amount)
        {
            base.Deposit(amount);
        }
        new public void Withdraw(int amount)
        {
            if (base.Balance >= amount)
            {
                base.Withdraw(amount);
            }  
            else
            {
                Console.WriteLine("Withdraw CAN NOT Possible. Account Need To Reach Conditioned Time Period.");
                Console.WriteLine();
            }
        }
         new public void Transfer(int amount, Account acc)
        {
            if (base.Balance >= amount)
            {
                base.Transfer(amount, acc);
            }
            else
            {
                Console.WriteLine("Transfer CAN NOT Possible. Account Need To Reach Conditioned Time Period.");
                Console.WriteLine();
            }
        }
    }
}
