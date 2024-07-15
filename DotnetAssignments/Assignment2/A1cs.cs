using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Debt
    {
        double damount = 1000;
        double ramount = 100;
        double balance = 1000;
        double mintrest = 0.015;

        public void repayment()
        {
            int i = 1;
            while (balance > 0)
            {
                balance = (damount + (damount * mintrest) - ramount);
                Console.WriteLine(i + " month balance : " + balance + "total payments :" + ramount);
                ramount = ramount + 100;
                i++;
            }
        }

    }
    internal class A1cs
    {
        static void Main()
        {
            Debt d = new Debt();
            d.repayment();

        }
    }
}
