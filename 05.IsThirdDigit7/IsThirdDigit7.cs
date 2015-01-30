/*Write an expression that checks for given integer 
 if its third digit from right-to-left is 7.
 Examples:

n	    Third digit 7?
5	    false
701	    true
9703	true
877	    false
777877	false
9999799	true*/
using System;

class IsThirdDigit7
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            bool isThirdDigitSeven = false;

            int firstReminder = number/100;
            int secondReminder = firstReminder%10;

            if (secondReminder == 7)
            {
                isThirdDigitSeven = true;
            }
            Console.WriteLine(isThirdDigitSeven);
        }
    }

