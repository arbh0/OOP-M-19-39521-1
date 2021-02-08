using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_1_8_
{
    class Program
    {
        static void Main(string[] args)
        {
            int marks;
            var arr = new int[] { 70, 85, 57, 74,70};
            double avg = Queryable.Average(arr.AsQueryable());
            Console.WriteLine("Average = " + avg);

            marks = (int)avg;
                if (marks > 89)
                {
                    Console.WriteLine("Grade A+");
                }
                else if (marks > 84 && marks < 90)
                {
                    Console.WriteLine("Grade A");
                }
                else if (marks > 79 && marks < 85)
                {
                    Console.WriteLine("Grade B+");
                }
                else if (marks > 74 && marks < 80)
                {
                    Console.WriteLine("Grade B");
                }
                else if (marks > 49 && marks < 76)
                {
                    Console.WriteLine("Grade C+");
                }
                else
                {
                    Console.WriteLine("Grade F");
                }
            
            Console.ReadLine();
        }
    }
}
