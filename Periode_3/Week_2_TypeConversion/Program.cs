using System;

namespace Week_2_TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variables
            string userInputString;
            int userInputInt;
            bool isInt;
            #endregion

            #region TheCode
            Console.WriteLine("Enter a number... or not... :");
            GetUserInput();
            ConvertToInt();

            while (!isInt) // as long as isInt is not true
            {
                Console.WriteLine($"Your input was {userInputString} and could not be converted to an integer.");
                Console.WriteLine();
                Console.WriteLine("Please enter a valid number this time : ");
                GetUserInput();
                ConvertToInt();
            }

            Console.WriteLine($"YEEEY!!!\nYour input was {userInputString} and could be converted to the integer {userInputInt}.");
            #endregion

            #region Functions
            void GetUserInput()
            {
                // get the user input
                userInputString = Console.ReadLine();
            }

            void ConvertToInt()
            {
                // try to convert the input to an int and save it to the userInputInt variable
                // if this succeeds we set the isInt variable to true
                // if not it is set to false
                isInt = int.TryParse(userInputString, out userInputInt);
            }
            #endregion
        }
    }
}
