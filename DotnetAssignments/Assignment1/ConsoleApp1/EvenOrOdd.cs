using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class EvenOrOdd
    { static void Main()
        {
            Console.WriteLine("Enter a Number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Here is the Result :");
            if (num % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("odd number");
            }
        }

    }
}
