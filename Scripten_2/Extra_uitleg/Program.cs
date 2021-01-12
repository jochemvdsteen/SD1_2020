using System;

namespace Extra_uitleg
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variableen staan boven aan
            // Dan komt je code waarin je de variabele nen mothods gebruikt
            // Onderaan staan de methods

            #region Variabelen
            // Variabele declaratie
            // heeft een type (string)
            // heeft naam (usertInput)
            // naam begint altijd met een lowercase
            int count = 5;
            #endregion

            #region Codeblok
            // 1 optellen
            // neemt de waarde van count en telt er een bij op
            // de waarde van count wordt hier niet aangepast maar gebruikt
            Console.WriteLine($"count + 1 = {count + 1}");
            Console.WriteLine($"count + 1 = {count + 1}");
            Console.WriteLine($"count + 1 = {count + 1}");

            // Nu gaan we count gebruiken en meteen aanpassen...
            Console.WriteLine("Original count : " + count);

            // We roepen de method AddOne() aan
            AddOne();
            AddOne();
            Console.WriteLine("Count + 2x AddOne() : " + count);

            // Add(2)
            // Add() is de method aanroep
            // 2 is de waarde die we meegeven aan de method
            Add(2);
            Console.WriteLine("Count + 1x Add(2) : " + count);

            Substract(2);
            Substract(2);
            Console.WriteLine("Count + 2x Substract(2) : " + count);

            // Print de nieuw waarde van count
            Console.WriteLine("New count : " + count);
            #endregion


            #region Methods
            // Methods hebben een type (void), 
            // een naam die beschrijvend is voor wat de method doet en begint met een hoofdletter (AddOne)
            // () haakjes waar de parameter in gaan
            // en {} haakjes waar de code in zit
            void AddOne()
            {
                // count++ : eerst waarde gebruiken en dan 1 optellen
                // ++count : eerst 1 optellen en dan waarde gebruiken
                ++count;
            }

            // deze method verwacht een parameter
            // in dit geval een integer
            // de meegeven waarde slaan we op in de locale variabele n
            // deze method verwacht altijd een waarde die meegegeven wordt
            // doe je dat niet dan krijg je een error
            void Add(int n)
            {
                // int n is de variabele waar de meegegeven waarde in wordt opgeslagen
                // += telt n op bij count en slaat deze waarde op in de variabele count
                // is gelijk aan count = count + n;
                count += n;
            }

            void Substract(int n)
            {
                // int n is de variabele waar de meegegeven waarde in wordt opgeslagen
                // trekt n af van count en slaat deze waarde op in de variabele count
                // is gelijk aan count = count - n;
                count -= n;
            }
            #endregion

            #region ClearConsole
            Console.WriteLine();
            Console.WriteLine("Press enter to clear console and continue...");
            Console.ReadLine();
            Console.Clear();
            #endregion

            #region Variables
            // Variabele declaratie
            // heeft een type (string)
            // heeft naam (usertInput)
            // naam begint altijd met een lowercase
            string userInput;
            #endregion

            #region Codeblok
            Menu();
            Check();
            #endregion

            #region Methods
            // conditie checks : 
            // == : is gelijk aan
            // != : is niet gelijk aan
            // <= : kleiner of gelijk
            // >= : groter of gelijk
            // <, > : kleiner dan, groter dan
            void Check()
            {
                if (userInput == "1")
                {
                    OptieJa();
                }
                else if (userInput == "2")
                {
                    OptieNee();
                }
                else
                {
                    OptieAnders();
                }
            }

            // Method
            // heeft een type (void = voert code uit maar geeft niets terug)
            // heeft naam, naam begint met een hoofd letter.
            void Menu()
            {
                Console.WriteLine("Hello World! Are you ok?");
                Console.WriteLine("1. Ja");
                Console.WriteLine("2. Nee");

                userInput = Console.ReadLine();
            }

            void OptieJa()
            {
                Console.WriteLine("Good");
            }

            void OptieNee()
            {
                Console.WriteLine("Ow no...");
            }

            void OptieAnders()
            {
                Console.WriteLine("Try again...");
                Menu();
                Check();
            }
            #endregion
        }
    }
}
