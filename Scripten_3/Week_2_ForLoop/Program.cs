using System;

namespace Week_2_ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // FOR LOOPS

            int num = 10;

            // we want to print the numbers 1 to 10 to the console
            // this can easily be done with a For loop

            // for() : this initiates the loop
            // int i = 0 : sets a local variable to count with
            // i < integer : as long as this condition is not met, the loop will start again
            // i++ : here we add 1 to i to keep track of the amount of loops we cycled through
            // {do stuff} : this is the block of code that is run

            // the basic for loop looks like this...
            // i starts at 0
            // every loop we add 1 to i 
            // till i equals the value of num, which is 10
            // but since i starts at 0 and keeps running as long as i is lower than 42 this loop will print 0 to 9
            Console.WriteLine("FOR LOOP 1 -----------------");
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(i);
                System.Threading.Thread.Sleep(30); // for the fun of it, we wait 30 milliseconds
            }
            ClearConsole();

            // we can solve this by adding 1 to i when we print it
            Console.WriteLine("FOR LOOP 2 -----------------");
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(i + 1);
                System.Threading.Thread.Sleep(30);
            }
            ClearConsole();

            // or we can tweak the loop to start at 1 and run as long as i is lower or equal to num
            Console.WriteLine("FOR LOOP 3 -----------------");
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i);
                System.Threading.Thread.Sleep(30);
            }
            ClearConsole();

            // we can also count backwards
            Console.WriteLine("FOR LOOP 4 -----------------");
            for (int i = num; i > 0; i--)
            {
                Console.WriteLine(i);
                System.Threading.Thread.Sleep(30);
            }
            ClearConsole();



            // Another example...
            Console.WriteLine("FOR LOOP 5 -----------------");
            Console.WriteLine("Good day! How long would you like to scream?");
            Console.Write("Please enter a number between 1 and 100: ");
            Console.WriteLine();

            // convert the string input to a string so we can use it in the for loop 
            int length = int.Parse(Console.ReadLine());

            Console.Write($"The length of your scream will be: {length}");
            Console.WriteLine();

            // we loop the amount of times provided by the user
            // each loop the character "A" gets printed to the console
            for (int i = 0; i < length; i++)
            {
                Console.Write("A");
                System.Threading.Thread.Sleep(30);
            }

            // and we close the scream...
            Console.Write("H!!!!");
            Console.WriteLine();

            ClearConsole();


            // combining loops with logic
            int count = 10;

            for (int i = 1; i <= count; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine("FIVE WOOP WOOP NUMBER FIVE");
                }
                else
                {
                    Console.WriteLine(i);
                }
                System.Threading.Thread.Sleep(30);
            }
            ClearConsole();


            void ClearConsole()
            {
                Console.WriteLine("Press [enter] to continue...");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
