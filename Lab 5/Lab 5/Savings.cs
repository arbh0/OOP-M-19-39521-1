﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Savings : Account
    {
        double minBal = 430;
        public Savings() {}
        public Savings(string acName, string acId, double balance) : base(acName, acId, balance) {}
        new public void Deposit(double amount)
        {
            base.Deposit(amount);
        }
        new public void Withdraw(double amount)
        {
            if ((base.Balance - amount) >= minBal)
            {
                base.Withdraw(amount);
            }
            else
            {
                Console.WriteLine("Withdraw CAN NOT Possible. User Does Not Have Balance.");
                Console.WriteLine();
            }
        }
        public void Transfer(double amount, Account acc)
        {
            if ((base.Balance - amount) >= minBal)
            {
                base.Transfer(amount, acc);
            }
            else
            {
                Console.WriteLine("Transfer CAN NOT Possible. User Does Not Have Balance.");
                Console.WriteLine();
            }
        }
    }
}
