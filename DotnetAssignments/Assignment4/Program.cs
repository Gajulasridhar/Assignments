using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Assignment3
{
    internal class BookStore
    {
        public string ISBN { get; set; }
        public string BookName { get; set; }
        public string BookTitle { get; set; }
        public string BookAuthor { get; set; }

        public int Quantity { get; set; }
        public int BookPrice { get; set; }

        public void DisplayBookDetails()
        {
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Book Name: {BookName}");
            Console.WriteLine($"Book Title: {BookTitle}");
            Console.WriteLine($"Book Author: {BookAuthor}");
            Console.WriteLine($"Quantity of Books: {Quantity}");
            Console.WriteLine($"Book Price: ${BookPrice}");
            Console.WriteLine($"Total Cost for {BookTitle} book is : ${CalculateTotalPrice()}");
        }


        public double CalculateTotalPrice()
        {
            return Quantity * BookPrice;
        }


        static void Main()
        {
          

            BookStore[] bookStore = new BookStore[2];

            for (int i = 0; i < 2; i++)
            {
                bookStore[i] = new BookStore();
                Console.WriteLine("enter your book name");
                bookStore[i].BookName = Console.ReadLine();
                bookStore[i].DisplayBookDetails();
            }
        }
    }
}