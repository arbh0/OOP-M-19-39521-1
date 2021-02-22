using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine();

            Savings s1 = new Savings("Rashed", "11111", 20000);
            Savings s2 = new Savings("Rakib", "22222", 5000);
            s1.Deposit(1000);
            s1.Withdraw(500);
            s1.Transfer(1000, s2);

            Console.WriteLine("-----------------------------");
            Console.WriteLine();

            SpecialCurrent sc1 = new SpecialCurrent("Rashed", "11111", 20000);
            SpecialCurrent sc2 = new SpecialCurrent("Rakib", "22222", 5000);
            sc1.Deposit(1000);
            sc1.Withdraw(500);
            sc1.Transfer(1000, sc2);

            Console.WriteLine("-----------------------------");
            Console.WriteLine();

            Fixed f1 = new Fixed("Rashed", "11111", 20000, 2);
            Fixed f2 = new Fixed("Rakib", "22222", 5000, 3);
            f1.Deposit(1000);
            f1.Withdraw(500);
            f1.Transfer(1000, f2);

            Console.WriteLine("-----------------------------");
            Console.WriteLine();

            OverDraft od1 = new OverDraft("Rashed", "11111", 20000);
            OverDraft od2 = new OverDraft("Rakib", "22222", 5000);
            od1.Deposit(1000);
            od1.Withdraw(500);
            od1.Transfer(5000, od2);

            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.ReadLine();
        }
    }
}
