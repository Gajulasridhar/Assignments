using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CommandLineArguement_2
    {
        static void Main() {
            Console.WriteLine("Enter your Name :");
            String name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Here is the Result:");
            Console.WriteLine($"Hi! {name} Welcome to the World of c#");
                }
    }
}
