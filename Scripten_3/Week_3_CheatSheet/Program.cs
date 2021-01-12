using System;

namespace Week_3_CheatSheet
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variables
            // Variables always have a type, name and value
            // the name starts with a lowercase letter
            // you can set the value at initialization 
            string thisString = "bla";

            // or after
            string thatString;
            thatString = "foo";

            // you can also change the value later on
            thatString = "bar";

            // there are multiple variable types
            char letter = 'b'; // this type holds only one character
            int number = 1; // this type only round numbers
            float floatNumber = 0.2f; // this type has decimal number
            double otherNumber = 1.5; // this one also, but bigger
            bool yesNo = true; // this type only accepts true or false

            // You can print variable values to the console
            Console.WriteLine($"The variable values... : {thisString}, {thatString}, {letter}, {number}, {floatNumber}, {otherNumber}, {yesNo}.");
            #endregion

            #region UserInput
            // Print code to the console            
            Console.WriteLine("Hello World!");

            // When asking for input always be specific
            Console.WriteLine("Please press [enter] to continue...");
            
            // Wait for user input
            Console.ReadLine();

            // Capture and store the user input in a string variable
            string userName; // Declare the variable with a type and a name
            Console.WriteLine("Please enter your name : "); // Ask for user input
            userName = Console.ReadLine(); // assign the input value to the string. Console.Readline is always a string
            Console.WriteLine("Your name is : " + userName); // Show the input in the cosole like this... or
            Console.WriteLine("Your name is : {0}", userName); // this.. or
            Console.WriteLine($"Your name is : {userName}"); // this
            #endregion


            #region IF-statement
            // We use an IF statement to only run our code when a certain condition is met
            // Frequently used condition checks are : 
            // == : equal to
            // != : is not equal to
            // <= : smaller than or equal to
            // >= : larger than or equal to
            // <, > : smaller than, larger than
            if (true)
            {
                // When the condition is true
                // then the code between these {} brackets is run
            }
            
            // We can also check multiple conditions with : 
            // && : AND
            // || : OR
            if (true && true)
            {
                // When both conditions are true
                // then the code between these {} brackets is run
            }

            if (true || false)
            {
                // When one of the conditions is true
                // then the code between these {} brackets is run
            }

            // We can extend IF statements to multiple checks with an ELSE-IF
            string check = "monkey";

            if (check == "foo")
            {
                // Check does not equal foo
                // the code between these {} brackets is not run
            }
            else if (check == "bar")
            {
                // Check does not equal bar
                // the code between these {} brackets is not run
            }
            else
            {
                // check is not foo or bar
                // the code between these {} brackets is not run
            }
            #endregion


            #region Methods
            // Keep your code clean and readably by using methods
            // They also prevent code duplication
            // and make it easier to change your code later on

            // Call the method
            ExampleMethod();
            int x = ReturnMethod();

            Console.WriteLine("I am a value returned by a method... : ", x);

            // Define the method
            // Methods have a type, name, brackets for parameters () and a code block {}
            // When a method runs some code we use a type void
            void ExampleMethod()
            {
                Console.WriteLine("I am a method...");
            }

            // When it returns a value the type is the value it returns
            int ReturnMethod()
            {
                int n = 1;
                return n;
            }
            #endregion


            #region Scope
            // Scope means the levels in which a variable is usable
            // Simple explanation is this...
            // A variable can be used a level deeper, not higher
            string varInMain = "Var in Main";

            void scopeExample()
            {
                // vanInMain is declared in a higher level so can be used
                // in this method
                Console.WriteLine(varInMain);
            }

            void scopeExample2()
            {
                // vanInMethod is declared in the method and can only be used inside the method
                // so not a level higher, outsode of it
                string varInMethod = "Var in Method";

                if (true)
                {
                    // vanInMain can be used in this IF statement
                    // because it is a level deeper from scopeExample2
                    Console.WriteLine(varInMethod);
                }
            }

            // but vanInMethod can not be used here
            #endregion


            // Deeper explanations of the code snippets below can be 
            // found in the corresponding projects in this solution

            #region TypeConversion String to Int
            string numberString = "123";
            int numberInt;

            numberInt = int.Parse(numberString);
            #endregion

            #region Random
            Random rnd = new Random();
            int d20Roll = rnd.Next(1, 21);
            #endregion

            #region BetterTypeConversion
            string userInputString = "69";
            int userInputInt;
            bool isInt;

            isInt = int.TryParse(userInputString, out userInputInt);
            #endregion

            #region FOR-loop
            int forN = 10;
            for (int i = 0; i < forN; i++)
            {
                // As long as the condition is met
                // the code is this part is run
            }
            #endregion

            #region WHILE-loop
            int whileN = 0;
            while (whileN < 10)
            {
                // As long as the condition is met
                // the code is this part is run

                whileN++;
            }
            #endregion

            #region DOWHILE-loop
            int doWhileN = 0;
            do
            {
                // This code runs furst
                // As long as the condition is met
                // the code will keep repeating

                doWhileN++;

            } while (doWhileN < 10);
            #endregion

            #region Nested-loops
            int outerLoop = 0,
                innerLoop = 0;

            for (int i = 1; i <= 5; i++)
            {
                outerLoop++;

                for (int j = 1; j <= 5; j++)
                {
                    innerLoop++;
                }
            }

            while (true)
            {
                for (int i = 0; i < 5; i++)
                {
                    // loop inside a loop
                }
            }
            #endregion

            #region Module

            Console.WriteLine($"The remainder of 5 modulo 3 = {5 % 3}");
            #endregion
        }
    }
}
