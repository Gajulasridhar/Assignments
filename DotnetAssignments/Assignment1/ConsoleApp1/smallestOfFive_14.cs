using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class smallestOfFive_14
    {
        static void Main()
        {
            int[] arr = new int[5];
            int small = 0;
            Console.WriteLine("Enter the Elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++)
            {
                small = arr[0];
                if (arr[i]<=small)
                {
                    small = arr[i];
                }

            }
            Console.WriteLine($"The smallest number is:{small}");
        }
    }
}
