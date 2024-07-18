namespace Assignment_linkedList_hashset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            //using addfirstmethod()
            list.AddFirst(10);
            list.AddFirst(20);
            list.AddFirst(30);
            
            
          foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
