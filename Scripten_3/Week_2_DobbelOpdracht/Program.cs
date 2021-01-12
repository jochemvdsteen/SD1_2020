using System;

namespace Week_2_DobbelOpdracht
{
    /*
     * Maak een spel voor 2 spelers.
     * Beide spelers starten met 5 levens.
     * Elke ronde rollen beide spelers ieder 2 D6 dobbelstenen.
     * De speler met de laagste worp verliest een leven.
     * Dit gaat door tot één van de spelers geen levens meer heeft.
     * 
     * Bescrhijf in de console de regels van het spel.
     * Vraag de spelers hun namen in te voeren en gebruik deze ook.
     * Laat tijdens het spel in de console zien wie wat heeft gerolt.
     * Laat tijdens het spel in de console zien hoeveel levens elke speler na elke ronde heeft. 
     * Laat aan het eind van het spel zien wie er gewonnen heeft.
     * 
     * Lukt dit dan ga je je spel verder uitbreiden met :
     * De mogelijkheid om levens terug te verdienen. Bijvoorbeeld als een speler 2 zessen gooit.
     * En/of een "Nog een keer spelen?" optie.
     */

    class Program
    {
        static void Main(string[] args)
        {

            #region Variables
            Random rnd = new Random();

            bool play = true;

            string playerOneName,
                   playerTwoName;

            int lives = 3,
                playerOneLife = lives,
                playerOneRoll1,
                playerOneRoll2,
                playerOneRollTotal,
                playerTwoLife = lives,
                playerTwoRoll1,
                playerTwoRoll2,
                playerTwoRollTotal;
            #endregion

            #region Code
            DisplayRules();
            GetPlayerNames();
            Continue();
            
            while (play == true)
            {
                Console.Clear();

                do
                {
                    Console.WriteLine("- THE ROLLS --------------------");
                    RollDice();
                    CheckDoubles();
                    Console.WriteLine();
                    UpdateLives();
                    DisplayPlayerLives();
                    Console.WriteLine("--------------------------------");
                    Continue();

                } while (playerOneLife > 0 && playerTwoLife > 0);

                Console.WriteLine("- FINAL SCORE ------------------");
                DisplayPlayerLives();
                Console.WriteLine();
                ShowFinalScore();
                Console.WriteLine("--------------------------------");

                PlayAgain();
            }
            #endregion

            #region Functions
            void DisplayRules()
            {
                Console.WriteLine("Roll dice, lose lives!");
                Console.WriteLine("2 players roll dice...");
                Console.WriteLine("Lowest score looses a life!");
                Console.WriteLine();
            }

            void GetPlayerNames()
            {
                Console.Write("Player One, what is your name? : ");
                playerOneName = Console.ReadLine();

                Console.Write("Player Two, what is your name? : ");
                playerTwoName = Console.ReadLine();
            }

            void DisplayPlayerLives()
            {
                Console.WriteLine($"{playerOneName} has {playerOneLife} out of {lives} lives."); 
                if (playerOneLife < 0)
                {
                    Console.WriteLine($"{playerOneName} died :(");
                }

                Console.WriteLine($"{playerTwoName} has {playerTwoLife} out of {lives} lives.");
                if (playerTwoLife < 0)
                {
                    Console.WriteLine($"{playerTwoName} died :(");
                }
            }

            void RollDice()
            {
                playerOneRoll1 = rnd.Next(1, 7);
                playerOneRoll2 = rnd.Next(1, 7);
                playerOneRollTotal = playerOneRoll1 + playerOneRoll2;
                Console.WriteLine($"{playerOneName} rolled {playerOneRoll1} and {playerOneRoll2}. Making a total of {playerOneRollTotal}.");

                playerTwoRoll1 = rnd.Next(1, 7);
                playerTwoRoll2 = rnd.Next(1, 7);
                playerTwoRollTotal = playerTwoRoll1 + playerTwoRoll2;
                Console.WriteLine($"{playerTwoName} rolled {playerTwoRoll1} and {playerTwoRoll2}. Making a total of {playerTwoRollTotal}.");
            }

            void CheckDoubles()
            {
                if (playerOneRoll1 == 6 && playerOneRoll2 == 6)
                {
                    Console.WriteLine($"{playerOneName} rolled double 6 and gained a life!");
                    playerOneLife++;
                }

                if (playerTwoRoll1 == 6 && playerTwoRoll2 == 6)
                {
                    Console.WriteLine($"{playerTwoName} rolled double 6 and gained a life!");
                    playerTwoLife++;
                }
            }

            void UpdateLives()
            {
                if (playerOneRollTotal > playerTwoRollTotal)
                {
                    Console.WriteLine($"{playerOneName} won this round!");
                    Console.WriteLine($"{playerTwoName} lost a life...");
                    playerTwoLife--;
                }
                else if (playerOneRollTotal < playerTwoRollTotal)
                {
                    Console.WriteLine($"{playerTwoName} won this round!");
                    Console.WriteLine($"{playerOneName} lost a life...");
                    playerOneLife--;
                }
                else 
                {
                    Console.WriteLine("It was a tie...");
                    Console.WriteLine("No lives were lost...");
                }
                Console.WriteLine();
            }

            void ShowFinalScore()
            {
                if (playerOneLife > playerTwoLife)
                {
                    Console.WriteLine($"{playerOneName.ToUpper()} WON!!");
                }
                else if (playerOneLife < playerTwoLife)
                {
                    Console.WriteLine($"{playerTwoName.ToUpper()} WON!!");
                } 
                else
                {
                    Console.WriteLine("It was a tie...");
                }
            }

            void Continue()
            {
                Console.WriteLine();
                Console.WriteLine("Press [enter] to continue...");
                Console.ReadLine();
                Console.Clear();
            }

            void PlayAgain(){
                string playAgainInput;

                Console.WriteLine("Play again? [Y/n]");
                playAgainInput = Console.ReadLine();

                if(playAgainInput.ToLower() == "y")
                {
                    play = true;
                    playerOneLife = lives;
                    playerTwoLife = lives;
                }
                else if (playAgainInput.ToLower() == "n")
                {
                    play = false;
                }
                else
                {
                    PlayAgain();
                }
            }
            #endregion
        }
    }
}
