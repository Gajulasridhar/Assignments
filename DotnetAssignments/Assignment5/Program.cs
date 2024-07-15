using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    class Furniture
    {
        int oid;
        string odate;
        int qty;
        int tamt;
        string pMode;
        string ftype;
        public void show(int oid, string odate, int qty, int tamt, string pmode, string ftype)
        {
            Console.WriteLine("order id " + oid);
            Console.WriteLine("order odate " + odate);
            Console.WriteLine("order quantity " + qty);
            Console.WriteLine("total amount  " + tamt);
            Console.WriteLine("payment mode " + pmode);
            Console.WriteLine("furniture type " + ftype);
        }

    }
    class chair : Furniture
    {

        public chair()
        {
            Console.WriteLine("enter furniture type");
            string ftype = Console.ReadLine();
            if (ftype == "w")
            {
                Console.WriteLine("enter wood type");
                string wtype = Console.ReadLine();
                if (wtype == "t")
                {
                    Console.WriteLine("wood type taek");
                }
                else if (wtype == "r")
                {
                    Console.WriteLine("wood type rose wood");
                }
            }
            if (ftype == "p")
            {
                Console.WriteLine("wood type plastic chair");
            }

        }

    }
    class cot : Furniture
    {
        public cot()
        {
            Console.WriteLine("enter cot type");
            string ctype = Console.ReadLine();
            if (ctype == "w")
            {
                Console.WriteLine("It is a wood cot");
            }
            else if (ctype == "s")
            {
                Console.WriteLine("It is a steel cot");
            }


        }

    }
    internal class A2
    {
        string ftype;
        string ctype;

        static void Main(string[] args)
        {
            Console.WriteLine("what do u want to buy");
            string ftype = Console.ReadLine();
            if (ftype == "chair")
            {
                chair c = new chair();
                c.show(1, "12/12/2001", 1, 1000, "cash", ftype);

            }
            else if (ftype == "cot")
            {
                cot c = new cot();
                c.show(1, "12/12/2001", 1, 15000, "cash", ftype);
            }

        }
    }
}
