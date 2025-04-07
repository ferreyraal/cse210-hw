using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        Square square = new Square("red", 2.0);
        Rectangle rectangle = new Rectangle("violet", 1.5 , 3);
        Circle circle = new Circle("Blue", 5);

    
        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape item in shapes)
        {
            Console.WriteLine($"Shape color: {item.GetColor()} is {item.GetArea()}");

        }    
    }
}