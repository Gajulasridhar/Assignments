using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LinqAssignment
{
    internal class OrderDemo
    {
        public static void Main()
        {
            List<order> list = new List<order>()
        {
            new order() { OrderId = 1, OrderDate = new DateTime(2023, 2, 21), ItemName = "Mouse", Quantity = 2 },
            new order() { OrderId = 2, OrderDate = new DateTime(2023, 3, 11), ItemName = "Keyboard", Quantity = 1 },
            new order() { OrderId = 3, OrderDate = new DateTime(2023, 4, 15), ItemName = "Monitor", Quantity = 3 },
            new order() { OrderId = 4, OrderDate = new DateTime(2023, 5, 19), ItemName = "Laptop", Quantity = 5 },
            new order() { OrderId = 5, OrderDate = new DateTime(2023, 6, 21), ItemName = "Tablet", Quantity = 2 },
            new order() { OrderId = 6, OrderDate = new DateTime(2023, 7, 10), ItemName = "Printer", Quantity = 1 },
            new order() { OrderId = 7, OrderDate = new DateTime(2023, 8, 30), ItemName = "Scanner", Quantity = 4 },
            new order() { OrderId = 8, OrderDate = new DateTime(2023, 9, 15), ItemName = "Chair", Quantity = 10 },
            new order() { OrderId = 9, OrderDate = new DateTime(2023, 10, 3), ItemName = "Desk", Quantity = 6 },
            new order() { OrderId = 10, OrderDate = new DateTime(2023, 11, 8), ItemName = "Lamp", Quantity = 12 },
            new order() { OrderId = 11, OrderDate = new DateTime(2023, 11, 21), ItemName = "Mouse Pad", Quantity = 8 },
            new order() { OrderId = 12, OrderDate = new DateTime(2023, 12, 5), ItemName = "USB Cable", Quantity = 15 },
            new order() { OrderId = 13, OrderDate = new DateTime(2023, 12, 20), ItemName = "External HDD", Quantity = 2 },
            new order() { OrderId = 14, OrderDate = new DateTime(2024, 1, 8), ItemName = "Webcam", Quantity = 5 },
            new order() { OrderId = 15, OrderDate = new DateTime(2024, 1, 18), ItemName = "Microphone", Quantity = 3 },
            new order() { OrderId = 16, OrderDate = new DateTime(2024, 2, 10), ItemName = "Headphones", Quantity = 7 },
            new order() { OrderId = 17, OrderDate = new DateTime(2024, 2, 21), ItemName = "Speakers", Quantity = 2 },
            new order() { OrderId = 18, OrderDate = new DateTime(2024, 3, 5), ItemName = "Router", Quantity = 4 },
            new order() { OrderId = 19, OrderDate = new DateTime(2024, 3, 15), ItemName = "Smartphone", Quantity = 3 },
            new order() { OrderId = 20, OrderDate = new DateTime(2024, 3, 28), ItemName = "Projector", Quantity = 1 }
        };


            List<Item> items = new List<Item>()
        {
            new Item() { ItemName = "Mouse", Price = 25.99m },
            new Item() { ItemName = "Keyboard", Price = 45.00m },
            new Item() { ItemName = "Monitor", Price = 150.75m },
            new Item() { ItemName = "Laptop", Price = 999.99m },
            new Item() { ItemName = "Tablet", Price = 499.99m },
            new Item() { ItemName = "Printer", Price = 120.00m },
            new Item() { ItemName = "Scanner", Price = 85.50m },
            new Item() { ItemName = "Chair", Price = 60.00m },
            new Item() { ItemName = "Desk", Price = 200.00m },
            new Item() { ItemName = "Lamp", Price = 30.00m },
            new Item() { ItemName = "Mouse Pad", Price = 10.00m },
            new Item() { ItemName = "USB Cable", Price = 5.99m },
            new Item() { ItemName = "External HDD", Price = 80.00m },
            new Item() { ItemName = "Webcam", Price = 50.00m },
            new Item() { ItemName = "Microphone", Price = 35.00m },
            new Item() { ItemName = "Headphones", Price = 25.00m },
            new Item() { ItemName = "Speakers", Price = 45.00m },
            new Item() { ItemName = "Router", Price = 60.00m },
            new Item() { ItemName = "Smartphone", Price = 799.99m },
            new Item() { ItemName = "Projector", Price = 350.00m }
        };

            var e = from i in list
                     orderby i.OrderDate
                     orderby i.Quantity descending
                     select new { OrderId = i.OrderId, OrderDate = i.OrderDate, ItemName = i.ItemName, Quantity = i.Quantity };

            foreach (var o in e)
            {
                Console.WriteLine(o);
            }
            Console.Clear();
            //4. For the previous exercise, write a LINQ query that displays the details grouped by the month in
            // the descending order of the order date.

            var r = from i in list
                    group i by i.OrderDate.Month;
                 
            foreach (var o in r)
            {
                Console.WriteLine("IN the month {0}",o.Key);
                foreach (var t in o)
                {
                    Console.WriteLine("{0}\t{1}",t.OrderId,t.ItemName);
                }
            }
            Console.Clear();
            /*
             5. You have created Order class in the previous exercise and that has order id , item name, order
date and quantity . Create another class called Item that has item name and price. Write a LINQ
query such that it returns order id, item name, order date and the total price (price * quantity )
grouped by the month in the descending order of the order date.*/

            var k = from i in list
                    join j in items
                    on i.ItemName equals j.ItemName
                    select new { OrderId = i.OrderId, ItemName = i.ItemName, OrderDate = i.OrderDate, TotalPrice = j.Price * i.Quantity };
            foreach(var o in k)
            {
                Console.WriteLine(o);
            }

            //7.Check if all the quantities in the Order collection is > 0

            var check = (from i in list
                        where (i.Quantity == 0)
                        select i).ToList();
            if(check.Count > 0)
            {
                Console.WriteLine("yes there are items that have Quantity as 0");
            }
            else
                Console.WriteLine("all items having atleast one");

        }
    }
}
