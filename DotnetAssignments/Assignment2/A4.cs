using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Bookself
    {
        int bno;
        String bname;
        String bautor;
        int qob;
        int bprice;
        public void bookdetails(String bname)
        {
            if (bname == "manga")
            {
                Console.WriteLine("book name is " + bname);
                Console.WriteLine("book author is : sai");
                Console.WriteLine("book price is : 87");
                Console.WriteLine("quantity of books is : 100");
            }
            else if (bname == "a")
            {
                Console.WriteLine("book name is " + bname);
                Console.WriteLine("book author is : vastav");
                Console.WriteLine("book price is : 93");
                Console.WriteLine("quantity of books is : 100");
            }
            else if (bname == "b")
            {
                Console.WriteLine("book name is " + bname);
                Console.WriteLine("book author is : sridhar");
                Console.WriteLine("book price is : 110");
                Console.WriteLine("quantity of books is : 100");
            }
            else Console.WriteLine("no such book in store");
        }
        public void bookprice(String bname)
        {
            if (bname == "manga")
            {
                bprice = 87;
                Console.WriteLine("your total bill is " + bprice);
            }
            if (bname == "a")
            {
                bprice = 93;
                Console.WriteLine("your total bill is " + bprice);
            }
            if (bname == "b")
            {
                bprice = 110;
                Console.WriteLine("your total bill is " + bprice);
            }

        }
    }
    internal class A4
    {
        static void Main()
        {
            Bookself b1 = new Bookself();
            b1.bookdetails("manga");
            b1.bookprice("manga");
            Console.WriteLine("_____________________________________________________________");
            Bookself b2 = new Bookself();
            b2.bookdetails("a");
            b2.bookprice("a");
        }
    }
}
