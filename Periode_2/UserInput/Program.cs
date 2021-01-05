using System;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;

            Console.WriteLine("Hello World!");
            Console.WriteLine("Are you feeling ok?");

            userInput = Console.ReadLine();

            // The question we asked is very open
            // This means we have to check for all kinds of possible answers
            // We could for example check for all Yes/No variations of user input
            if (userInput == "Yes" || userInput == "yes" || userInput == "Y" || userInput == "y")
            {
                Console.WriteLine("That's good to hear :)");
            }
            else if (userInput == "No" || userInput == "no" || userInput == "N" || userInput == "n")
            {
                Console.WriteLine("Oh no, that's to bad :(");
            }
            else
            {
                Console.WriteLine("I don't understand your answer...");
            }

            Console.WriteLine();
            Console.WriteLine("Press enter to clear console and continue...");
            Console.ReadLine();
            Console.Clear();

            //
            // Better would be to change the input to lowercase

            Console.WriteLine("Hello again World!");
            Console.WriteLine("Are you feeling ok?");

            userInput = Console.ReadLine();
            userInput = userInput.ToLower();

            // No we can do with only half of the checks
            if (userInput == "yes" || userInput == "y")
            {
                Console.WriteLine("That's good to hear :)");
            }
            else if (userInput == "no" || userInput == "n")
            {
                Console.WriteLine("Oh no, that's to bad :(");
            }
            else
            {
                Console.WriteLine("I don't understand your answer...");
            }


            Console.WriteLine();
            Console.WriteLine("Press enter to clear console and continue...");
            Console.ReadLine();
            Console.Clear();

            //
            // Or even better...
            // Specify what we what the user to input
            Console.WriteLine("Hello World!");
            Console.WriteLine("Are you feeling ok? [yes/no]");

            userInput = userInput.ToLower();

            // No we can do with only half of the checks
            if (userInput == "yes" || userInput == "y")
            {
                Console.WriteLine("That's good to hear :)");
            }
            else if (userInput == "no" || userInput == "n")
            {
                Console.WriteLine("Oh no, that's to bad :(");
            }
            else
            {
                Console.WriteLine("I don't understand your answer...");
            }


            Console.WriteLine();
            Console.WriteLine("Press enter to clear console and continue...");
            Console.ReadLine();
            Console.Clear();

            //
            // Or specify using a menu
            Console.WriteLine("Hello World!");
            Console.WriteLine("Are you feeling ok?");
            Console.WriteLine("[y] Yes");
            Console.WriteLine("[n] No");

            userInput = userInput.ToLower();

            // No we can do with only half of the checks
            if (userInput == "y")
            {
                Console.WriteLine("That's good to hear :)");
            }
            else if (userInput == "n")
            {
                Console.WriteLine("Oh no, that's to bad :(");
            }
            else
            {
                Console.WriteLine("I don't understand your answer...");
            }
        }
    }
}
