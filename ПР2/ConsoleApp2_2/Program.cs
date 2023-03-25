using System;
class Program
{
    static void Main(string[] args)
    {
        Pamagiti myObject = new Pamagiti();

        Console.WriteLine("Введите число 1:");
        while (true)
        {
            int input = int.Parse(Console.ReadLine());

            if (myObject.SetNumber(input))
            {
                Console.WriteLine("Введите число " + myObject.GetExpectedNumber() + ":");
            }
            else
            {
                Console.WriteLine("Подумай и введи число! Введите число 1:");
                myObject = new Pamagiti();
            }
        }
    }
}