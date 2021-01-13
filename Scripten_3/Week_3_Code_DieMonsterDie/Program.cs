using System;

namespace Week_2_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variables
            // defining a random number generator
            Random rnd = new Random();

            string playerName,
                   playerActionString;

            int playerHP = rnd.Next(30, 51), // variable player HP of 30 to 50
                monsterHP = rnd.Next(40, 71), // variable monster HP of 40 to 70
                playerAction,
                playerHitDice1,
                playerHitDice2,
                playerHitTotal,
                monsterHitDice;

            #endregion

            #region Code
            Console.WriteLine("------------------------");
            Console.WriteLine("- MONSTER HUNTER -------");
            Console.WriteLine("------------------------");

            AskPlayerName();
            CreateEncounter();

            while (monsterHP > 0 && playerHP > 0)
            {
                do
                {
                    AskAction();
                }
                while (!int.TryParse(playerActionString, out playerAction) || playerAction < 1 || playerAction > 2);

                DoAction();
            }
            #endregion

            #region Functions

            void AskPlayerName()
            {
                Console.WriteLine("What is your name brave hero? : ");
                playerName = Console.ReadLine();
                Console.WriteLine();
            }

            void CreateEncounter()
            {
                Console.WriteLine($"You are {playerName}!");
                Console.WriteLine($"You have {playerHP} hit points,");
                Console.WriteLine("and do 2 D10 damage...");
                Console.WriteLine();
                Console.WriteLine($"You encounter a vicious monster with { monsterHP } hitpoints,");
                Console.WriteLine("that does 1 D12 damage.");
                Console.WriteLine();
            }

            void AskAction()
            {
                Console.WriteLine("What do you do...");
                Console.WriteLine("1 : ATTACK!!!!");
                Console.WriteLine("2 : Run away...");
                playerActionString = Console.ReadLine();
                Console.WriteLine();
            }

            void DoAction() 
            {
                if (playerAction == 1)
                {
                    RollPlayerDice();
                    UpdateMonsterHealth();

                    Console.WriteLine();

                    if (monsterHP > 0)
                    {
                        RollMonsterDice();
                        UpdatePlayerHealth();

                        Console.WriteLine();
                    }
                }

                if (playerAction == 2)
                {
                    Console.WriteLine("You flee the scene screaming...");
                    playerHP = 0;
                }
            }


            void RollPlayerDice() 
            {
                playerHitDice1 = rnd.Next(1, 11);
                playerHitDice2 = rnd.Next(1, 11);
                playerHitTotal = playerHitDice1 + playerHitDice2;
                Console.WriteLine($"You do {playerHitTotal} damage!");
            };

            void RollMonsterDice()
            {
                monsterHitDice = rnd.Next(1, 13);
                Console.WriteLine($"The monster does {monsterHitDice} damage to you!");
            };

            void UpdateMonsterHealth() {
                monsterHP -= playerHitTotal;
                Console.WriteLine($"The monster has {monsterHP} hit points left...");

                if (monsterHP < 1)
                {
                    Console.WriteLine("YOU WIN!!!");
                }
            };

            void UpdatePlayerHealth() {
                playerHP -= monsterHitDice;
                Console.WriteLine($"You have {playerHP} hit points left...");

                if (playerHP < 1)
                {
                    Console.WriteLine("You died...");
                }
            };

            #endregion
        }
    }
}
