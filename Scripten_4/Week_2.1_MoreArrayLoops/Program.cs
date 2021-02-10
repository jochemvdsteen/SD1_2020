using System;

namespace Week_2._1_MoreArrayLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            #region forLoop
            int max = 15;

            Console.WriteLine("Print 1 to 15...");
            for (int i = 0; i < max; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n");
            Console.WriteLine("Print even numbers from 0 to 15...");
            for (int i = 0; i < max; i += 2)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n");
            Console.WriteLine("Print even numbers from 0 to 15... with modulo...");
            for (int i = 0; i < max; i++)
            {
                if (i % 2 == 0) {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine("\n");
            Console.WriteLine("Print numbers from 0 to 15 which are devidable by 7...");
            for (int i = 0; i < max; i++)
            {
                if (i % 7 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine("\n");
            #endregion

            Console.WriteLine();
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();

            #region playerArray
            Console.WriteLine("Let's collect some player names...");
            int numNames = 5;
            string[] playerNames = new string[numNames];

            for (int i = 0; i < numNames; i++)
            {
                Console.Write("Please enter a name : ");
                playerNames[i] = Console.ReadLine();
            }

            Console.WriteLine("Show the names in the console...");
            foreach (string name in playerNames)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();
            #endregion

            #region reversePlayerArray
            Console.WriteLine("And now reversed...");

            Array.Reverse(playerNames);

            foreach (string name in playerNames)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();
            #endregion

            #region randomPlayerFromArray
            Console.WriteLine("Let's pick a random player...");

            Random rnd = new Random();
            int selection;

            selection = rnd.Next(0, numNames);
            Console.WriteLine(playerNames[selection]);
            #endregion

            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
            Console.Clear();

            #region ArrayHerhaling
            // fill array by hand
            int[] numberArray; // type int[] is a ninteger array, we give it the name numberArray
            numberArray = new int[3]; // we define it as a new array with 3 spaces to fill

            // add a value to every space (or index)
            numberArray[0] = 1;
            numberArray[1] = 2;
            numberArray[2] = 3;

            Console.WriteLine("Loop over the array using a for-loop...");
            
            for (int i = 0; i < numberArray.Length; i++)
            {
                Console.WriteLine(numberArray[i]);
            }
            
            Console.ReadLine();
            Console.WriteLine("Now lets create a new array, sort it and loop over them with a foreach-loop...");

            int[] newNumberArray = {2,85,36,9,34,787};
            Array.Sort(newNumberArray);

            foreach (int num in newNumberArray)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
            Console.Clear();
            #endregion
        }
    }
}
