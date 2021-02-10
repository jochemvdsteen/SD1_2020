using System;

namespace Week_1_Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            // array met bools, een stukje Russian Roulette
            Random rnd = new Random();
            bool[] revolver = new bool[6];

            revolver[0] = false;
            revolver[1] = false;
            revolver[2] = false;
            revolver[3] = false;
            revolver[4] = false;
            revolver[5] = false;

            LoadBullet();

            Console.WriteLine(revolver[0]);
            Console.WriteLine(revolver[2]);
            Console.WriteLine(revolver[1]);
            Console.WriteLine(revolver[3]);
            Console.WriteLine(revolver[4]);
            Console.WriteLine(revolver[5]);

            void LoadBullet()
            {
                int bullet = rnd.Next(0, 6); // denk aan upper bound
                revolver[bullet] = true;
            }

            // Array length uitlezen
            Console.WriteLine($"There's room for {revolver.Length} bullets in my revolver");


            Console.WriteLine("\n\n-----------------------------------------------");
            Console.WriteLine("Press any key to close the application...");
            Console.ReadKey();
        }
    }
}
