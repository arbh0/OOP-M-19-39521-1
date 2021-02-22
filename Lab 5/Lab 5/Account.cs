using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Account
    {
        string acName;
        string acId;
        double balance;
        public string AccName
        {
            set
            {
                acName = value;
            }
            get
            {
                return acName;
            }
        }
        public string Acid
        {
            set
            {
                acId = value;
            }
            get
            {
                return acId;
            }
        }
        public double Balance
        {
            set
            {
                balance = value;
            }
            get
            {
                return balance;
            }
        }
        public Account() { }
        public Account(string acName, string acId, double balance)
        {
            this.acName = acName;
            this.acId = acId;
            this.balance = balance;
        }
        public void Deposit(double amount)
        {
            if(amount>0)
            {
                Console.WriteLine("Account Holder Name : " + acName);
                Console.WriteLine("Account Number      : " + acId);
                Console.WriteLine("Previous Balance    : " + balance); Console.WriteLine();
                Console.WriteLine("Deposit Amount      : " + amount); Console.WriteLine();
                balance = balance + amount;
                Console.WriteLine("Money has been depositted. ");
                Console.Write(acName);
                Console.WriteLine("'s present balance is "+ balance);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid Amount!!");
            }
        }
        public void Withdraw(double amount)
        {
            Console.WriteLine("Previous Balance    : " + balance);
            Console.WriteLine("Withdraw Amount     : " + amount); Console.WriteLine();
            balance = balance - amount;
            Console.WriteLine("Money has been withdrawn. ");
            Console.Write(acName);
            Console.WriteLine("'s present balance is " + balance);
            Console.WriteLine();
        }
        public void Transfer(double amount, Account acc)
        {
            Console.WriteLine("Previous Balance    : " + balance);
            Console.WriteLine("Transfer Amount     : " + amount); Console.WriteLine();
            balance = balance - amount;
            acc.Balance = acc.Balance + amount;
            Console.WriteLine("Balance has been transfered. ");
            Console.Write(acName);
            Console.WriteLine("'s present balance is " + balance);
            Console.WriteLine();
        }
    }
}
