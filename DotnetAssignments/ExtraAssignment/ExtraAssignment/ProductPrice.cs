using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }

    public Product(int id, string name, double price)
    {
        Id = id;
        Name = name;
        Price = price;
    }

    public void IncreasePriceBy10Percent()
    {
        Price *= 1.10;
    }

    public override string ToString()
    {
        return $"{Id}, {Name}, {Price:F2}";
    }
}

class ProductPrice
{
    static void Main()
    {
        string filePath = "products.csv";
        List<Product> products = ReadProductsFromFile(filePath);
        IncreasePrices(products);
        WriteProductsToFile(filePath, products);
    }

    static List<Product> ReadProductsFromFile(string filePath)
    {
        List<Product> products = new List<Product>();

        foreach (var line in File.ReadLines(filePath))
        {
            string[] parts = line.Split(',');

            if (parts.Length == 3)
            {
                int id = int.Parse(parts[0].Trim());
                string name = parts[1].Trim();
                double price = double.Parse(parts[2].Trim(), CultureInfo.InvariantCulture);

                products.Add(new Product(id, name, price));
            }
        }

        return products;
    }

    static void IncreasePrices(List<Product> products)
    {
        foreach (var product in products)
        {
            product.IncreasePriceBy10Percent();
        }
    }

    static void WriteProductsToFile(string filePath, List<Product> products)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var product in products)
            {
                writer.WriteLine(product.ToString());
            }
        }
    }
}
