using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gajula_Sridhar_week1_Assesment
{
    internal class Q1
    {
       


        static void Main()
        {
            double principal = 1000.00;
            double rate = 0.05;
            double target = 100000.00;
            int years = 0;

          
            while (principal <= target)
            {
                principal += principal * rate;
                years++;
            }

            
            Console.WriteLine($"It will take {years} years");
        }
    }


}
