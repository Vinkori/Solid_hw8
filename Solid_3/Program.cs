using System;
using System.Runtime.InteropServices;

// Порушення якого принципу привело до невірного результату ?
interface IShape
{
    int GetArea();
}

class Rectangle : IShape
{
    public int Width { get; set; }
    public int Height { get; set; }
    public int GetArea()
    {
        return Width * Height;
    }
}

class Square : IShape
{
    public int Side { get; set; }
    public int GetArea()
    {
        return Side * Side;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.Width = 5;
            rect.Height = 10;

            Square sqr = new Square();
            sqr.Side = 5;
            sqr.Side = 10;

            Console.WriteLine(rect.GetArea());
            Console.WriteLine(sqr.GetArea());
            Console.ReadKey();
        }
    }
}