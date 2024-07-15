using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Assignment3
{
    class Shapes
    {
        // Method to calculate the area of a rectangle
        public double Area(double length, double width)
        {
            return length * width;
        }

        // Method to calculate the area of a triangle
        public double Area(double baseLength, double height, bool isTriangle)
        {
            if (isTriangle)
            {
                return 0.5 * baseLength * height;
            }
            else
            {
                throw new ArgumentException("Invalid argument for triangle area calculation");
            }
        }

        // Method to calculate the area of a circle
        public double Area(double radius)
        {
            return Math.PI * radius * radius;
        }

        // Method to calculate the area of a square
        public double Area(int side)
        {
            return side * side;
        }
    }

    class A3
    {
        static void Main(string[] args)
        {
            Shapes shapes = new Shapes();

            // Calculate and display the area of a rectangle
            double rectangleArea = shapes.Area(10, 5);
            Console.WriteLine($"Area of Rectangle: {rectangleArea}");

            // Calculate and display the area of a triangle
            double triangleArea = shapes.Area(10, 5, true);
            Console.WriteLine($"Area of Triangle: {triangleArea}");

            // Calculate and display the area of a circle
            double circleArea = shapes.Area(7);
            Console.WriteLine($"Area of Circle: {circleArea}");

            // Calculate and display the area of a square
            double squareArea = shapes.Area(4);
            Console.WriteLine($"Area of Square: {squareArea}");
        }
    }
}

