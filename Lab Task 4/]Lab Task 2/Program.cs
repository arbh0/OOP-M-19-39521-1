using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[] { 6, 7, 8, 9, 0 };
            int count;

            Console.WriteLine("Original array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Array in reverse order: ");

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }

            {
                var sum = 0;
                for (var i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
                Console.WriteLine("\nArray Sum: " + sum);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr2[i];
            }
            for (int k = 0; k < arr2.Length; k++)
            {
                Console.WriteLine(arr2[k] + "");
            }
            Console.WriteLine();

            for (int j = 0; j < arr.Length - 1; j++)
            {

                if (arr[j] == arr[j + 1])
                    count = count + 1;
            }
            Console.WriteLine("\t\n " + arr[i] + "occurse" + count);
            Console.ReadKey();
        }



    }
}
