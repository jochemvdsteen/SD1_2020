using System;

namespace Week_2._1_Enums
{
    class Program
    {
        #region topic
        /*
         * Enumerated types (Enums)
         * 
         * We have learned that the type of a variable defines the type of content it can hold.
         * For instance we know an int contains round numbers, a float contains decimal numbers, a string contains text and bool contains true/false.
         * But what if we want to use a different type? One which content we can define ourselves? 
         * We can do this using the enumerated type...        
         *
         * An enumerated type, or Enum, is a type that represents a constant collection of name/value pairs (or enum members).
         * By default, the associated values of enum members are of type int; 
         * they start with zero and increase by one following the name order.
         * 
         * You use enumerators if you have a fixed collection of related constants or options.
         * In previous lessons we created a set of menu items with an array,
         * since the menu options are static this can also be done with an enum. 
         * 
         * Enumerated types are define OUTSIDE the Main function.
         * 
         * Additionl references...
         * https://www.w3schools.com/cs/cs_enums.asp
         * https://www.tutorialsteacher.com/csharp/csharp-enum
         * https://www.c-sharpcorner.com/article/loop-through-enum-values-in-c-sharp/
         */
        #endregion

        #region Defining Enumerated types
        // ## DEFINING AN ENUM WITH AUTOMATICALLY ASSINGED NUMERIC VALUES
        //
        // To define an enumeration type, use the enum keyword and specify the names of enum members.
        // enum : creates a new enum
        // Direction : is the name for this enum
        // { } : holds the members of this enum

        enum Menu
        {
            Start,
            Rules,
            Quit
        }

        enum Colour
        {
            Yellow, // name is Yellow, value is 0
            White, // name is White, value is 1
            Purple, // name is Purple, value is 2
            Black // name is Black, value is 3
        };

        // ## DEFINING AN ENUM WITH CUSTOM NUMERIC VAULES
        //
        // You can also set your own values.
        // You will not use this in our lesons but it is good to know you have the option.
        enum ErrorCode
        {
            None = 0,
            Unknown = 1,
            ConnectionLost = 100,
            OutlierReading = 200
        }
        #endregion

        static void Main(string[] args)
        {
            #region Using Enumerated types
            // ## USE AN ENUM
            // First create a variable of the enum type you want to use
            // then you can assign it a member from the enum.
            // An additonal benefit of using enums is that Visual Studio shows you the availavle options
            Menu selectedMenuItem;
            selectedMenuItem = Menu.Start;

            // You can use the same enum for different variables            
            // Below we use the Direction enum to set a player direction
            Colour favouriteColour;
            favouriteColour = Colour.Black;

            // And now we define the direction the wind is coming from by using the same Direction enum
            Colour shirtColour;
            shirtColour = Colour.Purple;
            #endregion

            #region Using enum value to get the member name
            // ## USING ENUM VALUE
            // Sometimes you might want to use the enum int value instead of the full name
            // To do this you need to cast the enum member name to an int
            // This is done in the following way...
            int colourID = (int)Colour.White; // enum to int conversion
            Console.WriteLine("Colour ID is " + colourID); //output: 1 

            // or do the reverse,
            // casting an int value to the corresponding enum member name
            Colour themeColour = (Colour)0; // int to enum conversion
            Console.WriteLine("Theme colour is " + themeColour);//output: Yellow 
            #endregion

            #region Looping through enums
            // ## LOOP BY NAME
            // The code below uses a foreach loop to go over all members in the ErrorCode enum
            Console.WriteLine("We have these error codes :");
            foreach (string error in Enum.GetNames(typeof(ErrorCode)))
            {
                Console.WriteLine("- " + error);
            }

            // ## LOOP BY VALUE
            // Here we do the same but by value instead of name
            Console.WriteLine("now with corresponding value...");
            foreach (int i in Enum.GetValues(typeof(ErrorCode)))
            {
                Console.WriteLine($"- {(ErrorCode)i} has the value {i}"); // (ErrorCode)i converts the numeric value to the name value
            }
            #endregion
        }
    }
}
