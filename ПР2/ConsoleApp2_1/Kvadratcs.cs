using System;

class Kvadratcs
{
    private double a, b, c;
    private double x1, x2;

    public Kvadratcs(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    private double Discriminant()
    {
        return b * b - 4 * a * c;
    }
    public double A()
    {
        return a;
    }
    public double B()
    {
        return b;
    }

    public double C()
    {
        return c;
    }

    public double X1()
    {
        return x1;
    }

    public double X2()
    {
        return x2;
    }

    public void CalculateRoots()
    {
        double discriminant = Discriminant();

        if (discriminant > 0)
        {
            x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
        }
        else if (discriminant == 0)
        {
            x1 = -b / (2 * a);
            x2 = x1;
        }
        else
        {
            Console.WriteLine("Нет корней от слова совсем");
        }
    }
}