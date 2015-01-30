/*Write an expression that calculates rectangle’s perimeter and area by given width and height.*/
using System;

class RectanglePerimeterAndArea
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double perimeter = 2*(width + height);
            Console.WriteLine("Perimeter = " + perimeter);
            double area = width*height;
            Console.WriteLine("Area = " + area);
        }
    }

