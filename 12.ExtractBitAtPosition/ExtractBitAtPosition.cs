/*Write an expression that extracts from given integer 
 n the value of given bit at index p.
 Examples:

n	    binary representation	p	bit @ p
5	    00000000 00000101	    2	1
0	    00000000 00000000	    9	0
15	    00000000 00001111	    1	1
5343	00010100 11011111	    7	1
62241	11110011 00100001	    11	0*/
using System;

class ExtractBitAtPosition
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            var binary = Convert.ToString(number, 2).PadLeft(32, '0');
            Console.WriteLine("Binary representation of {0} is: {1}",number, binary);
            Console.WriteLine("Enter the bit position which you want to extract: ");
            int position = int.Parse(Console.ReadLine());
            int mask = 1 << position;
            int numberAndMask = number & mask;
            int bit = numberAndMask >> position;
            Console.WriteLine(bit);
        }
    }

