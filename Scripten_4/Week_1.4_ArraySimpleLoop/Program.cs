using System;

namespace Week_1_SimpleLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Maar dit kan toch allemaal veel handiger?
            // Nu schrijf ik alles uit
            // Maar dat is natuurlijk niet nodig

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            // Bijvoorbeeld met een for loop
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            Console.WriteLine("\nand again");
            Console.WriteLine("in reverse...\n");

            // Andere kant op
            Array.Reverse(cars);

            // Of met een Foreach loop
            //foreach (type variableName in arrayName)
            //{
            //    // code block to be executed
            //}

            foreach (string car in cars) // ik 'verzin' hier eigenlijk gewoon car, variabele bestaat binnen de context van de loop
            {
                Console.WriteLine(car);
            }

            // Beiden doen hetzelfde, maar de een is makkelijker en de andere is efficiënter... Welke is welke?
            // Nu oefenen met de gemaakte arrays in loops te zetten
            // Volgende week combineren we dit alles met eerder geleerde onderwerpen, en gaan we beginnen met een simpele game te maken


            Console.WriteLine("\n\n-----------------------------------------------");
            Console.WriteLine("Press any key to close the application...");
            Console.ReadKey();
        }
    }
}
