/*Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 
of given 32-bit unsigned integer.
 Examples:

n	        binary 	                            binary result	                    result
            representation of n
1140867093	01000100 00000000 01000000      	01000010 00000000 01000000 	        1107312677
                      00010101                            00100101
255406592	00001111 00111001 00110010 	        00001000 00111001 00110010 	        137966136
                     00000000                            00111000
4294901775	11111111 11111111 00000000      	11111001 11111111 00000000      	4194238527
                      00001111                            00111111
5351	00000000 00000000 00010100          	00000100 00000000 00010100      	67114183
                      11100111                            11000111
2369124121	10001101 00110101 11110111      	10001011 00110101 11110111      	2335569705
                      00011001                            00101001*/
using System;

class BitsExchange
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
           int mask = 1 << 3;
            int thirdBit = (number & mask) >> 3;
            mask = 1 << 24;
            int twentyFourthBit = (number & mask) >> 24;

            if (thirdBit == 0)
            {
                // put o in 24th position
                mask = ~(1 << 24);
                number = number & mask;
            }
            else if (thirdBit == 1)
            {
                // put 1 in 24th position
                mask = 1 << 24;
                number = number | mask;
            }
            if (twentyFourthBit == 0)
            {
                // put 0 in 3th position
                mask = ~(1 << 3);
                number = number & mask;
            }
            else if (twentyFourthBit == 1)
            {
                // put 1 in 3th position
                mask = 1 << 3;
                number = number | mask;
            }
            

            mask = 1 << 4;
            int fourthBit = (number & mask) >> 4;
            mask = 1 << 25;
            int twentyFifthBit = (number & mask) >> 25;

            if (fourthBit == 0)
            {
                // put o in 25th position
                mask = ~(1 << 25);
                number = number & mask;
            }
            else if (fourthBit == 1)
            {
                // put 1 in 25th position
                mask = 1 << 25;
                number = number | mask;
            }
            if (twentyFifthBit == 0)
            {
                // put 0 in 4th position
                mask = ~(1 << 4);
                number = number & mask;
            }
            else if (twentyFifthBit == 1)
            {
                // put 1 in 4th position
                mask = 1 << 4;
                number = number | mask;
            }
            

            mask = 1 << 5;
            int fifthBit = (number & mask) >> 5;
            mask = 1 << 26;
            int twentySixthBit = (number & mask) >> 26;

            if (fifthBit == 0)
            {
                // put o in 26th position
                mask = ~(1 << 26);
                number = number & mask;
            }
            else if (fifthBit == 1)
            {
                // put 1 in 26th position
                mask = 1 << 26;
                number = number | mask;
            }
            if (twentySixthBit == 0)
            {
                // put 0 in 5th position
                mask = ~(1 << 5);
                number = number & mask;
            }
            else if (twentySixthBit == 1)
            {
                // put 1 in 5th position
                mask = 1 << 5;
                number = number | mask;
            }
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            Console.WriteLine(number);
        }
    }
