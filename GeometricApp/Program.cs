using System;
using GeometricBL;
public class Program
{
    public static void Main(string[] args)
    {
        Circle c = new Circle(5, "Red", true);
        Rectangle r = new Rectangle(4, 3, "Green", true);
        Console.WriteLine(c.Area());
        Console.WriteLine(c.diameter());
        Console.WriteLine(c.Perimeter());
        Console.WriteLine(c.ToString());
        c.printcircle();
        Console.WriteLine(r.Area());
        Console.WriteLine(r.Perimeter());
        Console.WriteLine(r.ToString());


    }
}
    