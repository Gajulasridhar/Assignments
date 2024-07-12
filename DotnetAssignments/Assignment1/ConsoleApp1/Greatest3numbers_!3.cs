using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Greatest3numbers__3
    {
        static void Main()
        {
            Console.WriteLine("Enter three numbers");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine($"The greatest number among {n1},{n2},{n3} is; {n1}");
            }
            else if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine($"The greatest number among {n1},{n2},{n3} is; {n2}");
            }
            else
            {
                Console.WriteLine($"The greatest number among {n1},{n2},{n3} is; {n3}");
            }
        }
    }
}
