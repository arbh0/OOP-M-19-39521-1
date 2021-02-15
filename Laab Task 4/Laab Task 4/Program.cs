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
            /*reverse order array*/

            int[] arr = new int[] { 2, 4, 6, 8, 10, 12, 14, 16 };
            Console.WriteLine("# Reverse Order");
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine();

             /* Sum of all elements of the array */

            int[] arr1 = new int[] { 2, 4, 6, 8, 10, 12, 14, 16 };
            int sum = 0;
            for (int i = 0; i < arr1.Length; i++)
                sum += arr1[i];
            Console.WriteLine("# Sum of all elements of the array: {0}", sum);
            Console.WriteLine();

            /* Copy the element of one array to another array */

            int[] arr2 = new int[] { 2, 4, 6, 8, 10, 12, 14, 16 };
            int[] arrtmp = new int[arr2.Length];
            for (int i = 0; i < arr2.Length; i++)
                arrtmp[i] = arr2[arr2.Length - 1 - i];

            Console.WriteLine("# Copy the element of one array to another array");
            for (int i = 0; i < arrtmp.Length; i++)
                Console.WriteLine(arrtmp[i]);
            Console.WriteLine();
            
            /* Count total number of duplicate elements of the array */
            
            int[] arr3 = new int[] { 4, 5, 8, 6, 7, 6, 4, 2, 7, 9 };
            int max = 0;
            for (int i = 0; i < arr3.Length; i++)
                if (arr3[i] > max)
                    max = arr3[i];
            int[] arrCount = new int[max + 1];

            for (int i = 0; i < arrCount.Length; i++)
                arrCount[i] = 0;

            for (int i = 0; i < arr3.Length; i++)
                arrCount[arr3[i]]++;

            Console.WriteLine("# Count total number of duplicate elements of the array");
            for (int i = 0; i < arrCount.Length; i++)
                if (arrCount[i] > 1)
                    Console.WriteLine("{0} is {1} times", i, arrCount[i]);
            Console.WriteLine();

            /* Unique elements in an Array */

            Console.WriteLine("# Unique elements in an Array");
            for (int i = 0; i < arrCount.Length; i++)
                if (arrCount[i] == 1)
                    Console.WriteLine("{0} is {1} times", i, arrCount[i]);
            Console.ReadLine();
        }
    }
}