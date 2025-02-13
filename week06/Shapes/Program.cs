// Program.cs
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Create a list to hold shapes
        List<Shape> shapes = new List<Shape>();

        // Add different shapes to the list
        shapes.Add(new Square("Red", 4.0));
        shapes.Add(new Rectangle("Blue", 5.0, 6.0));
        shapes.Add(new Circle("Green", 3.0));

        // Iterate through the list and display the color and area of each shape
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.Color}, Area: {shape.GetArea()}");
        }
    }
}
