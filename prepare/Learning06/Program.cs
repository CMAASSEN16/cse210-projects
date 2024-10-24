using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Circle o1 = new Circle("Turqoise", 10);
        shapes.Add(o1);

        Square o2 = new Square("Blue", 6);
        shapes.Add(o2);
 
        Rectangle o3 = new Rectangle("Purple", 7, 9);
        shapes.Add(o3);

        foreach (Shape o in shapes)
        {
            string color = o.GetColor();

            double area = o.GetArea();

            Console.WriteLine($"The {color} object has an area of {area}.");
        }
    }
}