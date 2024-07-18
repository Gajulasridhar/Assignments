using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asssignment_7
{
    internal class Q2
    {
        static void Main()
        {
            List<string> sName = new List<string>();
            Console.WriteLine("Enter names (type 'done' to finish):");

            while (true)
            {
                string name = Console.ReadLine();
                if (name.ToLower() == "done") break;
                sName.Add(name);
            }

            sName.Sort();
            sName.Reverse();

            Console.WriteLine("Names in descending order:");
            foreach (string n in sName)
            {
                Console.WriteLine(n);
            }
        }
    }
}
