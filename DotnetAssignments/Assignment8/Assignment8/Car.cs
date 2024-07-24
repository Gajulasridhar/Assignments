using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
   class Car
    {
        public string CarMoadel;
        public DateOnly yom;
    }
    internal class Demo
    {
        public static void write(string path, string s)
        {
            using (StreamWriter sw = new StreamWriter(path,false))
            {
                sw.WriteLine(s);
            }
        }
        public static void read(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                sr.ReadToEnd();
            }
        }
        public static void Main()
        {
            Demo demo = new Demo();
            Console.WriteLine("Enter the car Model");
            string model=Console.ReadLine();
            Console.WriteLine("Enter the year of making");
            DateOnly yom=DateOnly.Parse(Console.ReadLine());
            string s=model+"\n"+yom;
            Demo.write("D://demo6.txt", s);
            Demo.read("D://demo6.txt");
        }

    }
}
