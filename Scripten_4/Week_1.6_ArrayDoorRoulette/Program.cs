using System;

namespace Week_1._6_ArrayDoorRoulette
{
    class Program
    {
        static void Main(string[] args)
        {   // Six doors...
            // Five doors hold a prize...
            // One door holds a grumpy clown...
            // How many door do you dare to open?
            //
            // Note that most of the code used in this example 
            // could and should really be put into methods...

            #region Variables
            Random rnd = new Random(); // define a random number generator
            bool[] doors = {true, true, true, true, true, true}; // create 6 doors
            bool continueDoors = true; // to check if the player wants to continue the game
            int doorPrize = 50; // sets the prize per door
            int playerPrize = 0; // stores the accumulated prize of the player
            string playerName; // stores the player name
            #endregion

            #region DoGame
            // put a clown behind a random door
            // note that we need a value from 0 to 5 because the last door index is 5
            // so the upper bound would be 6... we have six doors so doors.Length is 6
            // here you see the differense between index number (starting from 0) 
            // and length (starting from 1)
            int clownDoor = rnd.Next(0, doors.Length); // pick a random number
            doors[clownDoor] = false; // put a clown behind the door with that number

            // ask for the player's name
            Console.Write("Hello contestant, what is your name? : ");
            playerName = Console.ReadLine();

            Console.WriteLine();

            // them's the rules
            Console.WriteLine($"{playerName}, there are {doors.Length} doors...");
            Console.WriteLine("Five of them have moneys...");
            Console.WriteLine("One has a grumpy clown...");
            Console.WriteLine("How many doors do you dare to open?");

            Console.WriteLine("\n---------------------\n");

            Console.WriteLine("Let's go! Press enter to open your first door!");
            Console.ReadLine();

            // loop over the doors
            for (int i = 0; i < doors.Length; i++)
            {
                // when the door has a clown it's value is false
                // so when the door value is false, you get the clown and loose
                if (doors[i] == false)
                {
                    // do the lozer stuff
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Oh no, it's the grumpy clown!");
                    Console.WriteLine("You get a pie smacked in your face...");
                    Console.WriteLine("and loose all your moneys :(");
                    Console.ResetColor();
                    break; // no need to go further... end the loop.
                }
                else
                {
                    // when the door is safe, claim your reward
                    Console.ForegroundColor = ConsoleColor.Green; // fancy colors
                    Console.WriteLine($"Door number {i + 1} is safe!");
                    Console.WriteLine($"You win {doorPrize} euro!");
                    playerPrize += doorPrize; // add the door value to the player's totals prize
                    Console.WriteLine($"Your total prize is now {playerPrize} moneys!");
                    Console.ResetColor(); // reset the colors
                }

                CheckContinue(); // check if the player wants to try another door
                Console.WriteLine();

                // if the player wants to stop the continueDoors value is false
                // and the game ends
                if (continueDoors == false)
                {
                    // the game ends...
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Well done {playerName}, you survive the game and win {playerPrize} moneys!");
                    Console.ResetColor();
                    break; // the game is over... end the loop
                }
            }
            #endregion

            #region Methods
            void CheckContinue()
            {
                Console.WriteLine("\nDo you want to continue? [Y/n]");
                string userInput = Console.ReadLine().ToLower(); // input to lowercase for esy checking

                if (userInput == "y") // when the player want to continue the continueDoors variable is set to true
                {
                    continueDoors = true;
                } 
                else if (userInput == "n") // when the player want to continue the continueDoors variable is set to false
                {
                    continueDoors = false;
                }
                else
                {
                    // incorrect input... let's ask again...
                    Console.WriteLine("Please answer Y or N");
                    CheckContinue();
                }
            }
            #endregion


            Console.WriteLine("\n\n-----------------------------------------------");
            Console.WriteLine("Press any key to close the application...");
            Console.ReadKey();
        }
    }
}
