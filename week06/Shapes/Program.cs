using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Blue", 10);

        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());

        List<Shape> shapes = new List<Shape>();

        Rectangle rectangle = new Rectangle("Green", 10, 20);
        Circle circle = new Circle("Purple", 10.50);

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();

            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }


    }
}