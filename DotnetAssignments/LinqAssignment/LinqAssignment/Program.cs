namespace LinqAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Given an array of numbers. Find the cube of the numbers that are greater than 100 but less than
            //1000 using LINQ.

            int[] a = { 2,8,23, 45, 15, 20, 100, 150 };
            var e=from x in a
                  let y=x*x*x
                  where(y>100 && y<1000)
                  select x;
            foreach(var k in e)
            {
                Console.WriteLine(k);
            }

        }
    }
}
