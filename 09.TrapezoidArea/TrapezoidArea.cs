/*Write an expression that calculates trapezoid's area by given sides a and b and height h.*/
using System;

internal class TrapezoidArea
{
    private static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        double area = ((a + b)/2)*h;
        Console.WriteLine(area);
    }
}

