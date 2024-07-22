using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsonNewInterface
{
    internal class Nullable
    {
        public int Id { get; set; }
        public string Name { get; set; }
            
        public double? price { get; set; }

        public int? stock { get; set; }

        public override string ToString()
        {
            return $"ID :{Id} Name:{Name} Price:{price} stock:{stock}";
        }

        static void Main()
        {
            dynamic? j = null;
           
            Nullable nullable = new Nullable();
            nullable.Id = 1;
            nullable.Name = "test";
            Console.WriteLine(nullable.ToString());
        }
    }
}
