using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Table_11
    {
        static void Main()
        {
            Console.WriteLine("Enter a number");
            int num=int.Parse(Console.ReadLine());
            Console.WriteLine("The resultant Table is :");
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"{num}*{i}={num * i}");
               
                    
             }
        }
    }
}
