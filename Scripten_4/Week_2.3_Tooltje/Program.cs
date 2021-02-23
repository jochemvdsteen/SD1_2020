using System;

namespace Week_2._3_Tooltje
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Maak een toolje wat...
             * - de gebruiker vraagt om het te starten
             * - een lijst met minimaal 3 voorwerpen, karakters, shows of iets dergelijks doorloopt
             * - per optie de gebruiker vraagt of deze dit leuk vind ja of nee 
             *   protip: antwoorden kun je opslaan in een nieuwe array
             * - per vraag een random antwoord geeft (keuze uit minimaal 6)
             * - na alle opties gehad te hebben de leuk gevonden opties laat zien
             *   en een mening over de keuze geeft (keuze uit minimaal 6) 
             *
             * Zorg voor voldoende informatie naar de gebruiker
             * wees creatief, schrijf je eigen code en maak er iets leuks van.
             */

            /*
             * Tips
             * - Gebruik arrys.
             * - Met loops en ifjes kom je een heel eind...
             * - Als je door een array loopt met een loop kun je de index
             *   gebruiken om dezelfde locatie in een andere array te vullen.
             *   Of om informatie op dezelfde positie in een andere array op te halen.
             * - Bij de vraag of de gebruiker iets leuk vind of niet kun je foute invoer 
             *   gewoon als een ja of nee interpreteren. 
             */

            #region app
            Random rnd = new Random();
            string[] objects = { "pink", "monkey", "potato" };
            string[] responses = new string[5];
            string[] reviews = new string[8];
            
            string user;
            string userInput;
            bool[] userLikes = new bool[objects.Length];

            responses[0] = "Oh my...";
            responses[1] = "You dont say...";
            responses[2] = "Hmmm... interesting...";
            responses[3] = "One wonders...";
            responses[4] = "Hahaha!! Ow, sorry...";
            responses[5] = "ieuw... scary...";

            reviews[0] = "Lorem ipsum dolor.";
            reviews[1] = "What? No way...";
            reviews[2] = "Monkey monkey monkey... banana";
            reviews[3] = "Bsdesfsd..sdfsdfsewfs!";
            reviews[4] = "Whoever this is, leave me alone!";
            reviews[5] = "There are many moons but only one is ours.";
            reviews[6] = "It sucks...";
            reviews[7] = "I love it, please give me more...";

            Console.WriteLine("What is you name huuuuman? : ");
            userInput = Console.ReadLine();
            user = userInput;

            for (int i = 0; i < objects.Length; i++)
            {
                Console.Write($"Do you like {objects[i]}? [y/n]: ");
                userInput = Console.ReadLine().ToLower();

                if (userInput == "y") 
                {
                    userLikes[i] = true;
                    Console.WriteLine(RandomResponse());
                }
                else if (userInput == "n")
                {
                    userLikes[i] = false;
                    Console.WriteLine(RandomResponse());
                }
                else
                {
                    userLikes[i] = false;
                    Console.WriteLine("Ok... I'll take that as a no...");
                }

                Console.WriteLine();
            }

            for (int i = 0; i < userLikes.Length; i++)
            {
                if (userLikes[i] == true)
                {
                    Console.WriteLine($"{user}, you like {objects[i]}... we say this about {objects[i]} : ");
                    Console.WriteLine("\"" + RandomReview() + "\"");
                    Console.WriteLine();
                }
            }

            string RandomResponse()
            {
                return responses[rnd.Next(0, responses.Length)];
            }

            string RandomReview()
            {
                return reviews[rnd.Next(0, reviews.Length)];
            }

            #endregion
        }
    }
}
