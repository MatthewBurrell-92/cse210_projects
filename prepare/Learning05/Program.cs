using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("blue", 4);
        Circle circle = new Circle("green", 3.2F);
        Rectangle rectangle = new Rectangle("white", 2, 3);
        // Console.WriteLine(square.GetColor());
        // Console.WriteLine(square.GetArea());
        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(circle);
        shapes.Add(rectangle);
        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}