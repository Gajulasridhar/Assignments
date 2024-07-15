
using System.IO;


namespace Gajula_Sridhar_week1_Assesment

{

    class FileDemo
    {
      
        public static void Write(String path)
        {
            Console.WriteLine("Enter model name :");

            string model = Console.ReadLine();
            Console.WriteLine("Enter year of the model :");
            string year = Console.ReadLine();
            File.AppendAllText(path, model);
            File.AppendAllText(path, year);

        }
       
    }
    internal class Q3
    {
        static void Main(string[] args)
        {
            try
            {
               
                FileDemo.Write("D:\\Dotnet\\Dotnetc#\\Gajula_Sridhar_week1_Assesment\\Example.txt");
               

            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
