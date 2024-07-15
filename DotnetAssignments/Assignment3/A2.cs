using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Assignment3
{
    class Building
    {
        public string Type { get; set; }
        public string Capacity { get; set; }
        public string Dimension { get; set; }
        public string FloorOrLandDimension { get; set; }
        public string DateOfCompletion { get; set; }

        // Constructor to initialize all data members
        public Building(string type, string capacity, string dimension, string floorOrLandDimension, string dateOfCompletion)
        {
            Type = type;
            Capacity = capacity;
            Dimension = dimension;
            FloorOrLandDimension = floorOrLandDimension;
            DateOfCompletion = dateOfCompletion;
        }

        // Method to display all data members
        public void ShowData()
        {
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Capacity: {Capacity}");
            Console.WriteLine($"Dimension: {Dimension}");
            if (Type == "Flat")
            {
                Console.WriteLine($"Floor Number: {FloorOrLandDimension}");
            }
            else if (Type == "Villa")
            {
                Console.WriteLine($"Land Dimension: {FloorOrLandDimension}");
            }
            Console.WriteLine($"Date of Completion: {DateOfCompletion}");
        }
    }

    class A2
    {
        static void Main(string[] args)
        {
            // Create instances of Building
            Building flat = new Building("Flat", "2BHK", "1000 sqft", "3", "2022-12-01");
            Building villa = new Building("Villa", "4BHK", "3000 sqft", "60X40", "2023-05-15");

            // Display data for Flat
            Console.WriteLine("Flat Details:");
            flat.ShowData();
            Console.WriteLine();

            // Display data for Villa
            Console.WriteLine("Villa Details:");
            villa.ShowData();
        }
    }
}

