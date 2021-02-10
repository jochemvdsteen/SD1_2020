using System;

namespace Week_1_SortReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array sorteren
            int[] numArray = { 6, 4, 118, 24 };

            Array.Sort(numArray);

            Console.WriteLine(numArray[0]);
            Console.WriteLine(numArray[1]);
            Console.WriteLine(numArray[2]);
            Console.WriteLine(numArray[3]);

            // Andere kant op (na eerst te hebben gesorteerd!)
            Array.Reverse(numArray);

            Console.WriteLine(numArray[0]);
            Console.WriteLine(numArray[1]);
            Console.WriteLine(numArray[2]);
            Console.WriteLine(numArray[3]);


            Console.WriteLine("\n\n-----------------------------------------------");
            Console.WriteLine("Press any key to close the application...");
            Console.ReadKey();
        }
    }
}
