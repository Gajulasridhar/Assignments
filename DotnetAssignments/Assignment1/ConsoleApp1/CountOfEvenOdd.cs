using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CountOfEvenOdd
    {
        static void Main()
        {
            int[] arr = new int[5];
            int Evencount = 0;
            int Oddcount = 0;
            Console.WriteLine("Enter the Elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)

                {

                    Evencount++;
                }
                else
                {
                    Oddcount++;
                }
            }
            Console.WriteLine($"Total even numbers count: {Evencount}\n Total odd numbers count: {Oddcount}");
        }
    }
}
