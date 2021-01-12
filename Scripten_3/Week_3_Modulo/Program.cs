using System;

namespace Week_3_Modulo
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Modulo gets the ramainder of a division.
            // When 5 is divided by 3, 
            // 3 fits one time in 5
            // so 5 - (3 * 1) = 5 - 3 = 2
            // the remainder is 2.
            Console.WriteLine($"The remainder of 5 modulo 3 = {5 % 3}");

            // When 1000 is divided by 90,
            // 90 fits 11 times,
            // so 1000 - (90 * 11) = 1000 - 990 = 10
            // the remainder is 10.
            Console.WriteLine($"The remainder of 1000 modulo 90 = {1000 % 90}");

            // When 100 is divided by 90, the remainder is also 10.
            Console.WriteLine($"The remainder of 100 modulo 90 = {100 % 90}");

            // When 81 is divided by 80, 
            // 81 - (80 * 1) = 81 - 80 = 1
            // the remainder is 1.
            Console.WriteLine($"The remainder of 81 modulo 80 = {81 % 80}");

            // When 10 is divided by 10, 
            // 10 - (10 * 1) = 10 - 10 = 0
            // the remainder is zero.
            Console.WriteLine($"The remainder of 10 modulo 10 = {10 % 10}");

            // When 25 is divided by 5, 
            // 25 - (5 * 5) = 25 - 25 = 0
            // the remainder is zero.
            Console.WriteLine($"The remainder of 25 modulo 5 = {25 % 5}");

            Console.WriteLine();

            // We can use this for calculations and FOR-loops
            int hundred = 100;

            // We count from one to hundred and check if the number is 
            // odd, even or ten fold...
            for (int i = 1; i <= hundred; i++)
            {
                // odd
                // if i is not dividable by two we have 1 left
                if (i % 2 == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(i + " is an ODD number");
                }

                // even
                // if i is dividable by two we have 0 left
                if (i % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(i + " is an EVEN number");
                }

                // every 10
                // if i is dividable by 10 we have 0 left
                if (i % 10 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("And " + i + " is also a TEN FOLD number");
                }
            }

            Console.ResetColor();
        }
    }
}
