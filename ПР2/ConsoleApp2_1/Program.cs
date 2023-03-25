using System;
class Program
{
    static void Main(string[] args)
    {
        double a = 8.2;
        double b = 9.0;
        double c = 3.5;

       Kvadratcs equation = new Kvadratcs(a, b, c);
        equation.CalculateRoots();

        Console.WriteLine($"The roots of the quadratic equation {a}x^2 + {b}x + {c} are:");
        Console.WriteLine($"x1 = {equation.X1()}");
        Console.WriteLine($"x2 = {equation.X2()}");
    }
}