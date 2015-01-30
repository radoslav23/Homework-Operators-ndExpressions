/*Write an expression that checks for given point (x, y) if it is 
within the circle K({1, 1}, 1.5) and out of the rectangle 
R(top=1, left=-1, width=6, height=2).
Examples:

x	    y	inside K & outside of R
1	    2	yes
2.5	    2	no
0	    1	no
2.5	    1	no
2	    0	no*/
using System;

class InCircleAndOutOfRectangle
    {
        static void Main()
        {
            //(x - center_x)^2 + (y - center_y)^2 < radius^2
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double kCenterX = 1;
            double kCenterY = 1;
            double radius = 1.5;
            double checkInCircle = ((x - kCenterX) * (x - kCenterX) +
                (y - kCenterY) * (y - kCenterY));
            bool inCircle = checkInCircle < radius*radius;
            bool outOfRectangle = x < 1 || x > 6 || y < -1 || y > 2;
            Console.WriteLine(inCircle && outOfRectangle);
        }
    }

