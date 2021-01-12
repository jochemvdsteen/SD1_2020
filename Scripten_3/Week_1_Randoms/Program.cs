using System;

namespace Week_1_Randoms
{
    class Program
    {
        static void Main(string[] args)
        {
            int d20Roll;
            // Randoms : a random number generator
            Random rnd = new Random();

            // assing a random value to the d20Roll integer variable
            // call the Next function of the rnd Random object and
            // provide the min up to max value
            // max value is up to, so the last number you want + 1
            d20Roll = rnd.Next(1, 21);

            // print the generated random value to the console
            Console.WriteLine("You rolled : " + d20Roll);

            Console.WriteLine("D6 roll : " + rollDice(6));
            Console.WriteLine("D10 roll : " + rollDice(10));
            Console.WriteLine("D20 roll : " + rollDice(20));

            // creating a rollDice funtion that accepts an amount of sides
            // this function is of the type int because it returns an int value
            // int rollDice is the function type and name
            // int sides is the parameter accepting an int value for the sides we want on our dice
            int rollDice(int sides)
            {
                return rnd.Next(1, sides + 1);
            }

            // print a line to the console which uses the rollDice funtion
            Console.WriteLine($"Roll d6 : {rollDice(6)} + Roll d20 : {rollDice(20)}");

            // we can also use the funtion in a variable and add the numbers of two rolls
            int dice1 = rollDice(10);
            int dice2 = rollDice(10);
            int totaal = dice1 + dice2;

            Console.WriteLine($"Roll d6 : {dice1} + Roll d20 : {dice2} = {totaal}");
        }
    }
}
