using System;

namespace Week_2._2_Reload
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reload mechanism

            #region Variables
            // the Nerf Mavrick has a cylinder with 6 darts
            bool[] nerfMaverickCylinder = new bool[6];
            bool isFullyLoaded = false;
            #endregion

            #region DoStuff
            // let's start with an empty Nerf
            Console.WriteLine("I'm holding a Mavrick with six chambers for darts...\nIt's the best Nerf gun ever...");
            for (int i = 0; i < nerfMaverickCylinder.Length; i++)
            {
                nerfMaverickCylinder[i] = false;
            }

            // Check if all chambers are truly empy...
            // better safe then sorry...
            Console.WriteLine("\nMy Nerf should be empty...Let's check...");
            CheckCylinder(); // check the cylinders

            ContinueAndClear();

            Console.WriteLine("Ok, now let's reload it!");
            Reload(); // do reload
            Console.WriteLine();
            CheckCylinder(); // check again to confirm reload

            ContinueAndClear();

            // let's shoot some darts...
            Console.WriteLine("I shot some darts... lets check which chambers are empty now...");            
            nerfMaverickCylinder[2] = false; // false means no dart, index 2 is the 3rd chamber
            nerfMaverickCylinder[4] = false; // and index 4 is the 5th chamber
            CheckCylinder();

            ContinueAndClear();

            // do the reloading thing again...
            Console.WriteLine("Ok, now let's reload again!");
            Reload(); // do reload
            Console.WriteLine();
            CheckCylinder(); // check again to confirm reload

            ContinueAndClear();
            #endregion

            #region Methods
            void CheckCylinder()
            {
                // loop ove rthe chambers in the cylinder to check for darts
                for (int i = 0; i < nerfMaverickCylinder.Length; i++)
                {
                    if (nerfMaverickCylinder[i] == false) // on false there is no dart... the chamber is empty
                    {
                        Console.WriteLine($"Chamber number {i + 1} is empty");
                        isFullyLoaded = false;
                    }
                    else // else it's true and there is a dart... the chamber is not empty
                    {
                        Console.WriteLine($"Chamber number {i + 1} contains a bullet");
                    }
                }

                // when we check all the chambers could be full
                // let's notify the user if that's the case
                if (isFullyLoaded == true)
                {
                    Console.WriteLine("The cylinder is fully loaded");
                }
            }

            void Reload()
            {
                // loop over all the chambers
                for (int i = 0; i < nerfMaverickCylinder.Length; i++)
                {
                    if (nerfMaverickCylinder[i] == false) // empty chamber... add a dart
                    {
                        Console.WriteLine($"You put a bullet in chamber {i + 1}");
                        nerfMaverickCylinder[i] = true;
                    }
                }

                // when al lchambers are reloaded set the isFullyLoaded to true
                isFullyLoaded = true;
            }

            void ContinueAndClear()
            {
                Console.WriteLine();
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();
                Console.Clear();
            }
            #endregion
        }
    }
}
