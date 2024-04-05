// Ian McMaster - CSE 210 - 3/25/2024

using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> imShapes = new List<Shape>();
        imShapes.Add(new Square("Red", 5));
        imShapes.Add(new Rectangle("Green", 4, 5));
        imShapes.Add(new Circle("Blue", 1));
        
        foreach (Shape imShape in imShapes)
        {
            Console.WriteLine(imShape.ImGetColor());
            Console.WriteLine(imShape.ImGetArea());
        }
    }
}