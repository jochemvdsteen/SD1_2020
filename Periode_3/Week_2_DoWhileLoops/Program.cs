using System;

namespace Week_2_DoWhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variables
            // we start at declare the variables we are using in our code
            string message1 = "This is message 1!";
            string message2 = "Here you go... message 2.";
            string message3 = "Message 3, good choice.";

            // here we decalre a string to capture user input
            string userInputString;

            // here we declare an int to store the userInputString converted to int
            int userInputInt;
            #endregion

            #region DoWhile
            Console.WriteLine("------------------------");
            Console.WriteLine("DO-WHILE LOOP ----------");
            Console.WriteLine("------------------------");
            Console.WriteLine();

            // executes code inside the DO code block and then check the WHILE condition
            // if the condition is met the DO part is executed again
            // if not... skip the code and continue...
            do
            {
                // call the function that prints the menu to the console
                PrintMenu();

            } while (!int.TryParse(userInputString, out userInputInt) || userInputInt < 1 || userInputInt > 3);

            // call the function that prints the sellected message to the console
            ShowMessage();

            #endregion

            #region WhileDo
            Console.WriteLine("------------------------");
            Console.WriteLine("WHILE-DO LOOP ----------");
            Console.WriteLine("------------------------");
            Console.WriteLine();

            // call the function that prints the menu to the console
            PrintMenu();

            // WHILE checks for a condition to be met
            // when the condition is met the code inside is executed
            // if not... skip the code and continue...
            while (!int.TryParse(userInputString, out userInputInt) || userInputInt < 1 || userInputInt > 3)
            {
                // call the function that asks for input again
                TryAgain();
            }

            // call the function that prints the sellected message to the console 
            ShowMessage();

            #endregion

            #region Functions
            // function of type void thar prints the menu to the console
            void PrintMenu()
            {
                Console.WriteLine("Welcome to the example menu");
                Console.WriteLine();
                Console.WriteLine("Press 1 to see message 1");
                Console.WriteLine("Press 2 to see message 2");
                Console.WriteLine("Press 3 to see message 3");
                Console.WriteLine();
                Console.Write("Enter your choice: ");
                userInputString = Console.ReadLine();

                Console.WriteLine();
            }

            // function of type void that asks the user to pick again
            void TryAgain()
            {
                Console.Write("Please enter a valid number: ");
                userInputString = Console.ReadLine();

                Console.WriteLine();
            }

            // function of type void that prints the correct message
            // using an IF statement
            void ShowMessage()
            {
                if (userInputInt == 1)
                {
                    Console.WriteLine(message1);
                }
                if (userInputInt == 2)
                {
                    Console.WriteLine(message2);
                }
                if (userInputInt == 3)
                {
                    Console.WriteLine(message3);
                }

                Console.WriteLine();
                Console.WriteLine("Thanks, bye.");
                Console.WriteLine();
                Console.WriteLine("Press [enter] to continue...");
                Console.ReadLine();
                Console.WriteLine();
            }
            #endregion
        }
    }
}
