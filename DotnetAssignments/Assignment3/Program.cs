using System;

namespace Assignment3
{
    class Person
    {
        public string Firstname, lastname, Emailadress;
        public DateTime DOB;

        public Person(string f, string l, string e, DateTime d)
        {
            this.Firstname = f;
            this.lastname = l;
            this.Emailadress = e;
            this.DOB = d;
            Console.WriteLine($"Firstname: {Firstname} lastname: {lastname} DOB: {DOB.ToShortDateString()} Email: {Emailadress}");
        }

        public Person(string f, string l, string e)
        {
            this.Firstname = f;
            this.lastname = l;
            this.Emailadress = e;
            Console.WriteLine($"Firstname: {Firstname} lastname: {lastname} Email: {Emailadress}");
        }

        public Person(string f, string l, DateTime d)
        {
            this.Firstname = f;
            this.lastname = l;
            this.DOB = d;
            Console.WriteLine($"Firstname: {Firstname} lastname: {lastname} DOB: {DOB.ToShortDateString()}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person obj = new Person("Sridhar", "yadav", "sridharyadav0852@gmail.com", new DateTime(2002, 11, 11));
            Person obj1 = new Person("Sridhar", "yadav", "sridharyadav0852@gmail.com");
            Person obj2 = new Person("Sridhar", "yadav", new DateTime(2002, 11, 11));
        }
    }
}
