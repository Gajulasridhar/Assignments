using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtraAss
{
    internal class Lamda
    {
        static void Main(string[] args)
        {
            List<int> NumList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            // Using lambda expression
            Console.WriteLine("Numbers divisible by 3 (using lambda expression):");
            List<int> divisibleByThree = NumList.Where(num => num % 3 == 0).ToList();

            foreach (int num in divisibleByThree)
            {
                Console.WriteLine(num);
            }
        }
    }
}