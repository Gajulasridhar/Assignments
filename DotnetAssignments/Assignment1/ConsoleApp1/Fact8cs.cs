using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Fact8cs
    {
        static void Main()
        {
            int fact = 1;
            Console.WriteLine("Enter a Number");
            int num = int.Parse(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine("number Cannot be negative");
            }
            if (num == 0 || num == 1)
            {
                Console.WriteLine("1");
            }
            else
            {
                for (int i = 1; i <= num; i++)
                {
                    fact = fact * i;
                }
                Console.WriteLine($"The factorial of {num} is : {fact}");
            }
        }

    }
}
