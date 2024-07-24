namespace Assignment8
{
    //Write a program to accept names of the users and store in a file.
    internal class Program
    {
        public static void Write(string path,string s)
        {
            File.AppendAllText(path, s);
        }
        static void Main()
        {

            //List<string> li= new List<string>();
            Console.WriteLine("Enter the no of users");
            int i=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the names of users");
            for (int j=0; j<i; j++)
            {
                //li.Add(Console.ReadLine());
                string s=$"{Console.ReadLine()}\n";
                Program.Write("D://Demo5", s);

            }
        }
    }
}
