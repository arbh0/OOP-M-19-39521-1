using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Fixed : Account
    {
        int tenureYear = 4, year;
        public Fixed() {}
        public Fixed(string acName, string acId, double balance, int year) : base(acName, acId, balance)
        {
            this.year = year;
        }
        new public void Deposit(double amount)
        {
            base.Deposit(amount);
        }
        new public void Withdraw(double amount)
        {
            if (tenureYear == this.year)
            {
                base.Withdraw(amount);
            }
            else
            {
                
            }
        }
        new public void Transfer(double amount, Account acc)
        {
            if (tenureYear == this.year)
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
