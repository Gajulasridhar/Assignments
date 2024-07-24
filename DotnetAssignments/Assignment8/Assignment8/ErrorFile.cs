using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    internal class ErrorFile
    {
        public static void write(string path, string s)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(s);
            }
        }
        static void Main()
        { 
        try
        {
                int a = 10;
                int i = a / 0;

        }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                ErrorFile.write("D://Error.txt",e.Message);

            }
        }
    }
}
