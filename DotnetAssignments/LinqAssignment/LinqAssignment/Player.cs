using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9.cs
{
    public class Players
    {
        public string Name { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return $"Player Name: {Name} , Country: {Country}";
        }
    }
    internal class Tennis
    {
        public static void Main()
        {
            List<Players> l = new List<Players>()
            {
                new Players(){Name = "Adarsh",Country = "India"},
                new Players(){Name = "Sudheer",Country = "UK"},
                new Players(){Name = "Surendra",Country = "Egypt"},
                new Players(){Name = "Jashwanth",Country = "Paris"},
                new Players(){Name = "Vastav",Country = "England"},
                new Players(){Name = "Sai",Country = "India"},
                new Players(){Name = "sreedhar",Country = "UK"},
                new Players(){Name = "Mani",Country = "USA"},
                new Players(){Name = "Rohith",Country = "USA"},
                new Players(){Name = "sanjay",Country = "Japan"},
                new Players(){Name = "chaitanya",Country = "Paris"},
            };
            int mid = l.Count / 2;
            var f = l.Take(mid).ToList();
            var s = l.Skip(mid).ToList();
            var result = from i in f
                         from j in s
                         where i.Country != j.Country
                         select new { p1 = i.Name, p2 = j.Name };
            foreach (var p in result)
            {
                Console.WriteLine($"{p.p1} - {p.p2}");
            }
        }
    }
}