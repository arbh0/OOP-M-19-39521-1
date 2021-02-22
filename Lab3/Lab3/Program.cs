using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Razib","19-00000-1", "CSE", 3.7F);
            s1.ShowInfo();
            Console.WriteLine("----------------------------------------------");

            Triangle t1 = new Triangle(6, 4, 4);
            t1.ShowInfo();
            t1.TestTriangle();
            Console.WriteLine("----------------------------------------------");

            Account a1 = new Account("Rashed", "55555", 10000);
            Console.Write("How much money do want to deposit? Enter Amount : ");
            int rdeposit = int.Parse(Console.ReadLine());
            a1.Deposit(rdeposit);
            Console.Write("How much money do want to withdraw? Enter Amount : ");
            int rwithdraw = int.Parse(Console.ReadLine());
            a1.Withdraw(rwithdraw);
            Console.WriteLine("----------------------------------------------");
            /*Account a2 = new Account();
            a2.setaccName("John");
            a2.setacid("65555");
            a2.setbalance(500);

            Console.Write("How much money do want to deposit? Enter Amount : ");
            int mdeposit = int.Parse(Console.ReadLine());
            a2.Deposit(mdeposit);
            Console.Write("How much money do want to withdraw? Enter Amount : ");
            int mwithdraw = int.Parse(Console.ReadLine());
            a1.Withdraw(mwithdraw);
            Console.WriteLine("----------------------------------------------"); */
            
            Course c1 = new Course("OOP2", "CSC3302", 3);
            c1.ShowCourseInfo();
            Console.ReadLine();
        }
    }
}
