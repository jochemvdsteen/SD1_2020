using System;

namespace Week_1_BasicArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays
            // Leg uit hoe je ze aanmaakt
            // En bespreek de properties van een array (onveranderlijke grootte bijvoorbeeld, ik vergelijk het altijd met hangars in een moederschip)
            // Besteed ook veel aandacht aan index

            // array met nummers
            int[] numberArray;
            numberArray = new int[3];

            // array vullen
            numberArray[0] = 10;
            numberArray[1] = 20;
            numberArray[2] = 30;

            // inhoud printen naar de console
            Console.WriteLine(numberArray[1]);

            Console.WriteLine();


            // array met strings
            string[] names = { "Tinky Winky", "Dipsy", "Laa-Laa", "Po" }; // kan ook ineens dus!

            // inhoud printen naar de console
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);

            Console.WriteLine();

            // array met strings
            string[] playerNames = new string[4];

            // array vullen met gebruikers input
            Console.WriteLine("Players, please enter your Names");
            Console.Write("Player 1, enter your name: ");
            playerNames[0] = Console.ReadLine();
            Console.Write("\nPlayer 2, enter your name: "); // \n?
            playerNames[1] = Console.ReadLine();
            Console.Write("\nPlayer 3, enter your name: ");
            playerNames[2] = Console.ReadLine();
            Console.Write("\nPlayer 4, enter your name: ");
            playerNames[3] = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine($"Player, your name is: {playerNames[0]}");
            Console.WriteLine($"Player, your name is: {playerNames[1]}");
            Console.WriteLine($"Player, your name is: {playerNames[2]}");
            Console.WriteLine($"Player, your name is: {playerNames[3]}");


            Console.WriteLine("\n\n-----------------------------------------------");
            Console.WriteLine("Press any key to close the application...");
            Console.ReadKey();
        }
    }
}
