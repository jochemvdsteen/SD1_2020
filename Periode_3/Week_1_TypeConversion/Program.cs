using System;

namespace Week_1_TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int age;
            int yearOfBirth;
            int year = 2020;

            // getting some user input
            Console.WriteLine("please enter your age:");
            userInput = Console.ReadLine();

            // print the user input
            Console.WriteLine($"Your age is : {userInput}");

            // convert the string input to an integer
            age = int.Parse(userInput);
            yearOfBirth = year - age;

            Console.WriteLine("You were born in : " + yearOfBirth);

            // you can also convert an integer to a string
            Console.WriteLine("This is your year of birth, but in a string {0}", yearOfBirth.ToString());

            // or convert a boolean to a string
            bool isTrue = true;
            string isTrueString = isTrue.ToString();

            Console.WriteLine("Bool : " + isTrue);
            Console.WriteLine("Bool string : " + isTrueString);
        }
    }
}
