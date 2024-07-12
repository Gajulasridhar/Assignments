using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FahrenhitToCelsius
    {
        static void Main()
        {
            Console.WriteLine("Enter temperature in fahrenheit :");
            float farh = float.Parse(Console.ReadLine());
            float celsius = (farh - 32) * 5 / 9;
            Console.WriteLine($"Coverted fahrenhit{farh}F into celsius={celsius}C");

        }
    }
}
