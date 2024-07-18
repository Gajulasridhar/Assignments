using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Tasks
{
    internal class StudentDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Branch { get; set; }

        public override string ToString()
        {
            return $"student id:{Id} Name:{Name} Branch:{Branch}";
        }

        static void Main()
        {
            StudentDetails s = new StudentDetails();

            s.Id = 101;
            s.Name = "Sridhar";
            s.Branch = "Cse";

            List<StudentDetails> studentDetailsList = new List<StudentDetails>();

            studentDetailsList.Add(new StudentDetails { Id = 112, Name = "Sai", Branch = "CSE" });
        }
    }
}