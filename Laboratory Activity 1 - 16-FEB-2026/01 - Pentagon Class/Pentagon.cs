using System;

class Pentagon
{
    private double side;
    public Pentagon()
    {
        side = 0;
    }
    public Pentagon(double side)
    {
        this.side = side;
    }
    public double GetPerimeter()
    {
        return 5 * side;
    }
    public double GetArea()
    {
        double factor = Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5)));
        return (factor * Math.Pow(side, 2)) / 4;
    }
    public void Display()
    {
        Console.WriteLine($"Side Length: {side}");
        Console.WriteLine($"Perimeter: {GetPerimeter():F3}");
        Console.WriteLine($"Area:  {GetArea():F3}");

    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Pentagon p1");
            Console.WriteLine("---------------------------");
            Pentagon p1 = new Pentagon();
            p1.Display();

            Console.WriteLine();

            Console.WriteLine("Pentagon p2");
            Console.WriteLine("---------------------------");
            Pentagon p2 = new Pentagon(5);
            p2.Display();
        }
    }
}