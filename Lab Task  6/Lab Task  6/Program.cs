using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task__6
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Razib", "111111", 3.5f);
            Student s2 = new Student("Rakib", "222222", 3.25f);
            Student s3 = new Student("Raj", "333333", 3.0f);

            Department d1 = new Department("CSE", "Computer Science And Engineering");
            Department d2 = new Department("FBA", "Bechalor Of Business Administration");

            Console.WriteLine("------------------------------------------------");
            s1.Dept = d1;
            d1.AddStudent(s1, s2, s3);
            d1.AddStudent(s2);
            s2.Dept = d2;

            s1.ShowSudentDeatils();
            Console.WriteLine("------------------------------------------------");
            s3.ShowSudentDeatils();
            Console.WriteLine("------------------------------------------------");
            d1.Name = "Computer Science and Engineering";
            d1.Id = "CSE";
            s2.ShowSudentDeatils();
            Console.WriteLine("------------------------------------------------");
            Console.ReadLine();
        }
    }
}
