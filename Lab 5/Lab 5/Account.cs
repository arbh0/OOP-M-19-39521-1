using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Account
    {
        string accName;
        string acid;
        int balance;
        public string AccName
        {
            set
            {
                accName = value;
            }
            get
            {
                return accName;
            }
        }
        public string Acid
        {
            set
            {
                acid = value;
            }
            get
            {
                return acid;
            }
        }
        public int Balance
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
        public Account(string accName, string acid, int balance)
        {
            this.accName = accName;
            this.acid = acid;
            this.balance = balance;
        }
        public void deposit(double amount)
        {
            if(amount>0)
            {
                
            }
        }
    }
}
