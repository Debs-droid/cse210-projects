using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("purple", 5);
        shapes.Add(s1);

        Rectangle r1 = new("green", 6, 3);
        shapes.Add(r1);

        Circle c1 = new("red", 3);
        shapes.Add(c1);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetArea());
            Console.WriteLine(shape.GetColor());
        }
        
        
        // Console.WriteLine("Hello World! This is the Shapes Project.");

        // Square s = new Square("purple", 5);

        // Console.WriteLine(s.GetArea());
        // Console.WriteLine(s.GetColor());

        // Rectangle r = new Rectangle("green", 6, 3);

        // Console.WriteLine(r.GetArea());
        // Console.WriteLine(r.GetColor());

        // Circle c = new Circle("red", 3);

        // Console.WriteLine(c.GetArea());
        // Console.WriteLine(c.GetColor());

    }
}