using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SumofCubes
    {
        static void Main()
        {
            int sum = 0;
            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                sum = (sum + (i * i * i));

            }
            Console.WriteLine($"Sum of cubes for {num} is :{sum}");
        }
    }
}
