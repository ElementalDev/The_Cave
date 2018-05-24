using System;

namespace The_Cave
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                PrintIntro();
                PlayGame();
                PrintSummary("Ending1");

            } while (AskToPlayAgain());

        }

        public static void PrintIntro()
        {
            //Print intro

            //Have some ASCII art
            Console.WriteLine("       THE CAVE");
            Console.WriteLine();
            Console.WriteLine("   ----------------");
            Console.WriteLine("  /  ------------  \\");
            Console.WriteLine(" (  (############)  )");
            Console.WriteLine("(   (############)   )");
            Console.WriteLine("(   (############)   )");
            Console.WriteLine("(   (############)   )");
            Console.WriteLine("----------------------");

            //Tell user what the game is
            //Explain rules and mechanics to user

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("| -This is a game of adventure!                                              |");
            Console.WriteLine("| -Choose your profession! Each one gives you different abilities and stats  |");
            Console.WriteLine("| -Find your way out of the cave.                                            |");
            Console.WriteLine("| -Use items to help you defeat the enemies that stand in your way           |");
            Console.WriteLine("| -Find treasures that you can take back to the surface!                     |");
            Console.WriteLine("| -Use words to navigate. Type help for the keywords!                        |");
            Console.WriteLine("------------------------------------------------------------------------------");
        }

        public static char GetDifficulty()
        {
            string diff = "";

            Console.WriteLine("What difficulty would you like to play? (Easy, Medium, Hard)");
            diff = Console.ReadLine();

            diff = diff.ToLower();

            return diff[0];
        }


        public static void PlayGame()
        {
            TheCave game = new TheCave();

            //Generate Map (Possibly 2d array)

            object[,] GameMap = game.MapCreate(GetDifficulty());

            Random rand = new Random();

            if (GetDifficulty() == 'e')
            {
                int num1 = rand.Next(1, 11), num2 = rand.Next(1, 11), numOfObjects = 2;

                Enemies enem = new Enemies();
                Armours arm = new Armours();
                Weapons wep = new Weapons();


            for (int i = 0; i < numOfObjects; i++)
            {
                GameMap[num1, num2] = enem;
                GameMap[num1, num2] = arm;
                GameMap[num1, num2] = wep;
            }

               int rowNums = GameMap.GetLength(0);
               int colNums = GameMap.GetLength(1);


            for (int i = 0; i < GameMap.GetLength(0); i++)
            {
                for (int j = 0; j < GameMap.GetLength(0); j++)
                {
                        Console.WriteLine(GameMap[i, j]);
                }
                    Console.WriteLine();
            }
        }

            //Run through game

            

            //Assign objects where necessary

            //Generate items around the area
            //Fixed areas
            //Can only hold a certain amount of items (Inventory)

            //Allow the use of objects where necessary
            //Give items certain boosts
            //Can drop item if necessary

            //Allow the user to make decision as to where they go
            //Forward, Back, Left, Right

            //Generate enemies
            //Generate attack and defense of enemies
            //Compare enemies stats to user
            //Depending on stats, depends on damage
            //DEF ATK HP

            //Have an end goal
            //Collected the right amount of quest items?
            //Make it out of the cave?
            //Kill a certain amount of enemies?

            //FUTURE REF: Perhaps have different quests that the user can choose from for replayability
            //FUTURE REF: Generate items in random places
            //FUTURE REF: Generate different maps each time

        }

        public static void PrintSummary(string ending)
        {
            //Base summary on choices within the game
            //2 Good endings
            //2 Bad endings

            //Show score

        }

        public static bool AskToPlayAgain()
        {
            string opt = "";

            Console.WriteLine("Play again if you dare! (Y/N)");
            opt = Console.ReadLine();


            return (opt == "y" || opt == "Y");
        }
    }
}
