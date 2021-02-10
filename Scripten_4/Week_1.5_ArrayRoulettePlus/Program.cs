using System;

namespace Week_1._5_ArrayRoulettePlus
{
    class Program
    {
        static void Main(string[] args)
        {
            // array met bools, een stukje Russian Roulette
            Random rnd = new Random();
            bool[] revolver = new bool[6];
            bool alive = true;
            bool again = false;

            revolver[0] = false;
            revolver[1] = false;
            revolver[2] = false;
            revolver[3] = false;
            revolver[4] = false;
            revolver[5] = false;

            LoadDart();

            // Array length uitlezen
            Console.WriteLine($"There are {revolver.Length} chambers in my Nerf revolver.");
            Console.WriteLine("Only one of them has a bullet...");
            Console.WriteLine("Press enter when you are ready!");
            Console.ReadLine();
            Console.WriteLine();

            for (int i = 0; i < revolver.Length; i++)
            {
                Console.WriteLine($"Chamber {i + 1} out of {revolver.Length}...");
                Console.WriteLine("You pull the trigger...");
                Console.WriteLine();

                pullTrigger(revolver[i]);

                if(alive == false)
                {
                    break;
                }

                Console.WriteLine();

                tryAgain();

                Console.ReadLine();
            }

            void LoadDart()
            {
                int bullet = rnd.Next(0, 6); // the last array index is 5 so the random upper bound is 6
                revolver[bullet] = true;
            }

            void pullTrigger(bool bullet)
            {               
                if (bullet == false)
                {
                    safe();
                }
                else
                {
                    dead();
                }
            }

            void safe()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("PFEW... empty chamber...");
                Console.ResetColor();
            }

            void dead()
            {
                alive = false;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("BIG BOOOM!");
                Console.WriteLine("A piece of plastic covered foam is launched against your head!");
                Console.WriteLine("You are in excruciating pain... but not really...");
                Console.ResetColor();
            }

            void tryAgain()
            {
                Console.WriteLine("Do you want to try again, or are you a chicken? [A/c] : ");
                string userInput = Console.ReadLine().ToLower();

                if (userInput == "a")
                {
                    again = true;
                    Console.WriteLine("Brave! Let's try it again then...");
                } 
                else if (userInput == "c")
                {
                    again = false;
                    Console.WriteLine("Ok... chicken... bye bye!");
                }
                else
                {
                    tryAgain();
                }
            }

            Console.WriteLine("\n\n-----------------------------------------------");
            Console.WriteLine("Press any key to close the application...");
            Console.ReadKey();
        }
    }
}
