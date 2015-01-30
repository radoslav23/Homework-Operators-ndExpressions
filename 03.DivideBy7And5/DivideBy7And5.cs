/*Write a Boolean expression that checks for given integer if it can be divided 
 (without remainder) by 7 and 5 at the same time.*/
using System;

class DivideBy7And5
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            bool divideBy7And5 = false;
            if (number % 5 == 0 & number % 7 == 0)
            {
                divideBy7And5 = true;
                if (number == 0)
                {
                    divideBy7And5 = false;
                }
            }
            Console.WriteLine(divideBy7And5);
        }
    }


