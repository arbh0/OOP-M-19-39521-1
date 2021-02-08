using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace lab_task_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0;
            Console.WriteLine("Even Numbers :");
            for (i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + "\n");
                }
            }
            int j, k, sum, esum = 0, osum = 0;
            
            for (j = 2; j <= 100; j += 2)
            {
                esum += i;
            }
            Console.WriteLine("Sum of all even number between 1 to 100 = " + esum);

            for (k = 1; i <= 100; i += 2)
            {
                osum += i;
            }
            Console.WriteLine("Sum of all odd numbers between 1 to 100 = " + osum);
            
            sum= esum + osum;
            Console.WriteLine("Sum of all even and odd number between 1 to 100 = " + sum);
            Console.ReadLine();
        }
    }
}
