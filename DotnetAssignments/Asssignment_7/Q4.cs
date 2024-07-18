using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asssignment_7
{
    internal class BookStore
    {
        public int BookId { get; set; }
        public string BookName { get; set; }

        static void Main(string[] args)
        {
            Dictionary<int, BookStore> bookDictionary = new Dictionary<int, BookStore>();

            while (true)
            {
                Console.WriteLine("1. Add Book\n2. Display Books\n3. Exit");
                Console.WriteLine("Select an option:");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        BookStore book = new BookStore();
                        Console.WriteLine("Enter Book ID:");
                        book.BookId = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Book Name:");
                        book.BookName = Console.ReadLine();

                        if (!bookDictionary.ContainsKey(book.BookId))
                        {
                            bookDictionary.Add(book.BookId, book);
                            Console.WriteLine("Book added successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Book ID already exists.");
                        }
                        break;

                    case 2:
                        if (bookDictionary.Count > 0)
                        {
                            foreach (var b in bookDictionary)
                            {
                                Console.WriteLine($"Book ID: {b.Value.BookId}, Book Name: {b.Value.BookName}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("books not available.");
                        }
                        break;

                    case 3:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
    }
}
