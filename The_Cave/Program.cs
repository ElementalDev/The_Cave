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
            Console.WriteLine("| - Choose your profession! Each one gives you different abilities and stats |");
            Console.WriteLine("| -Find your way out of the cave.                                            |");
            Console.WriteLine("| -Use items to help you defeat the enemies that stand in your way           |");
            Console.WriteLine("| -Find treasures that you can take back to the surface!                     |");
            Console.WriteLine("| -Use words to navigate. Type help for the keywords!                        |");
            Console.WriteLine("------------------------------------------------------------------------------");
        }

        public static void PlayGame()
        {
            //Run through game

            //Generate Map (Possibly 2d array)

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
