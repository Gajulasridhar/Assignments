using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class marks_15
    {
        static void Main()
        {
            int[] arr = new int[10];
            int small = 0, high = 0,Total=0,avg=0;
            Console.WriteLine("Enter the marks out of 100");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Total = Total +arr[i];
              
            }
            Console.WriteLine($"The Total marks is:{Total}");
            avg=Total/arr.Length;
            Console.WriteLine($"The average marks is:{avg}");
            for (int i = 1; i < arr.Length; i++)
            {
                small = arr[0];
                if (arr[i] < small)
                {
                    small = arr[i];
                }

            }

            Console.WriteLine($"The minimum marks is:{small}");
            for (int i = 1; i < arr.Length; i++)
            {
                high = arr[0];
                if (arr[i] > high)
                {
                    high = arr[i];
                }

            }
            Console.WriteLine($"The maximum marks is:{high}");
            Array.Sort(arr);
            Console.WriteLine("The marks in ascending order is");
           
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            Array.Reverse(arr);
            Console.WriteLine("The marks in Descending  order is ");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
