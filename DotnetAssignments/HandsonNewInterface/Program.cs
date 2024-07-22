

namespace HandsonNewInterface
{
    internal class Program
    {
        public dynamic employeeID;

        public dynamic Mul(dynamic a,dynamic b)
        {
            return a * b;

        }
        static void Main(string[] args)
        {
            dynamic a = 10;
            a = "david";
            Console.WriteLine(a);
            dynamic ab = a;
            Console.WriteLine(ab);
            Program program = new Program();
            program.employeeID = a;
           dynamic c= program.Mul(20,30);
            Console.WriteLine(c);
        }
    }
}
