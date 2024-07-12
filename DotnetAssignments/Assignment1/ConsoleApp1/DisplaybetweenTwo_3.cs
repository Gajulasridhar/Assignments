using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DisplaybetweenTwo_3
    {
        static void Main()
        {
            Console.WriteLine("Enter Lower limit");
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine("Higher limit");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("Here is the result: ");
            for (int i = l; i <= h; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
