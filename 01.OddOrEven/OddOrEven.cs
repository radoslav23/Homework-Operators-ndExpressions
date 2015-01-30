/*Write an expression that checks if given integer is odd or even.*/
using System;

class OddOrEven
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            bool odd = true;
            if (number % 2 == 0)
            {
                odd = false;               
            }
            Console.WriteLine(odd);
        }
    }

