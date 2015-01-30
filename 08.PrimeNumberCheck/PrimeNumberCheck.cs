/*Write an expression that checks if given positive integer number 
n (n ≤ 100) is prime (i.e. it is divisible without remainder only to itself and 1).
Note: You should check if the number is positive*/
using System;

class PrimeNumberCheck
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }          
        }
    }

