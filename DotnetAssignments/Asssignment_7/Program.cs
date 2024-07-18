namespace Asssignment_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            Console.WriteLine("Enter 10 numbers: ");

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(nums);

            Console.WriteLine("Numbers in ascending order: ");
            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }
        }
    }
}
