using System;

namespace Week_2_NestingLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("NESTING LOOPS ----------");
            Console.WriteLine("------------------------");
            Console.WriteLine();

            // declaring multiple variables of the same type
            // can also be writen like this...
            int outerLoop = 0, 
                innerLoop = 0;

            // first FOR loop
            // this loop will run 5 time
            for (int i = 1; i <= 5; i++)
            {
                // increase outerloop value by 1
                outerLoop++;

                // and a second FOR loop inside the first
                // this loop will run 5 x 5 times
                for (int j = 1; j <= 5; j++)
                {
                    // increase innerloop value by 1
                    innerLoop++;
                }
            }

            // print the results to the console
            Console.WriteLine("Outer Loop runs {0} times", outerLoop);
            Console.WriteLine("Inner Loop runs {0} times", innerLoop);


            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine();


            // another example
            
            // declare a variable of type int to keep track of the loops
            int n = 1;

            // keep looping as long as n is lower or equal to 5
            while (n <= 5)
            {
                // note the j <= n
                // n is the counting variable used for the WHILE loop
                // this FOR loop will run as many times as the parent WHILE loop has run
                for (int j = 1; j <= n; j++)
                {
                    // every loop this prints the value of j plus a space on the same line
                    Console.Write(j + " ");
                }

                // every loop we increase the value of n by 1
                n++;

                Console.WriteLine();
            }
        }
    }
}
