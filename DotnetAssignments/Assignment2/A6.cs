using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Student7
    {
        int roll;
        String Sname;
        int mie;
        int mim;
        int mis;
        public Student7(int roll, String Sname, int mie, int mim, int mis)
        {
            this.roll = roll;
            this.Sname = Sname;
            this.mie = mie;
            this.mim = mim;
            this.mis = mis;
        }
        public void total()
        {
            Console.WriteLine("student name is " + Sname + " roll no is " + roll);
            int total;
            total = mie + mim + mis;
            Console.WriteLine("total marks of student is " + total);

        }
        public void percentage()
        {

            int total;
            int per;
            total = mie + mim + mis;
            per = total / 300 * 100;
            Console.WriteLine("total percntage of student is " + per);

        }

    }
    internal class A6
    {
        static void Main()
        {
            Student7 s = new Student7(1, "sai", 100, 100, 100);
            s.total();
            s.percentage();
        }


    }

}
