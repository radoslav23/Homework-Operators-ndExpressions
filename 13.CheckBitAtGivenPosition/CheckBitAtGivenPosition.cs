/*Write a Boolean expression that returns if the bit at position p 
(counting from 0, starting from the right) in given integer number n, has value of 1.
 Examples:

n	    binary representation of n	p	bit @ p == 1
5	    00000000 00000101	        2	true
0	    00000000 00000000	        9	false
15	    00000000 00001111	        1	true
5343	00010100 11011111	        7	true
62241	11110011 00100001	        11	false*/
using System;

class CheckBitAtGivenPosition
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            var binary = Convert.ToString(number, 2).PadLeft(32, '0');
            Console.WriteLine("Binary representation of {0} is: {1}", number, binary);
            Console.WriteLine("Enter the bit position which you want to check is it has value of 1: ");
            int position = int.Parse(Console.ReadLine());
            int mask = 1 << position;
            int numberAndMask = number & mask;
            bool bit = (numberAndMask >> position) == 1;
            Console.WriteLine(bit);
        }
    }

