using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DivisibleBy7
    {
        static void Main()
        {
            Console.WriteLine("The numbers divisible by 7 is :");
            for(int i=200;i<=300;i++)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
