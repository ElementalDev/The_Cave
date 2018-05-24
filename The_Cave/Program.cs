using System;

namespace The_Cave
{
    class Program
    {   
        //Main code is run in here.
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                PrintIntro();
                GetProfession();
                GetDifficulty();
                PlayGame();
                PrintSummary("Ending1");

            } while (AskToPlayAgain());

        }

        //Print intro.
        public static void PrintIntro()
        {
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
            Console.WriteLine("|                                                                            |");
            Console.WriteLine("|                           Press enter to begin!                            |");
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.ReadLine();
        }

        //Ask the user what profession they want to use.
        public static Professions GetProfession()
        {
            Console.Clear();

            //Create all objects to use Gets

            Professions chosenProf = new Professions();
            Warrior war = new Warrior();
            Mage mage = new Mage();
            Hunter hun = new Hunter();

            //Input and validation variables

            string input = "";
            bool isValid = false;

            //Profession menu

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("| Which profession would you like to be? |");
            Console.WriteLine("|          (Type your selection)         |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("| - Warrior - HP= {0}, MP= {1}              |", war.GetHealth(), war.GetMag());
            Console.WriteLine("| - Mage - HP= {0}, MP= {1}                |", mage.GetHealth(), mage.GetMag());
            Console.WriteLine("| - Hunter - HP= {0}, MP= {1}              |", hun.GetHealth(), hun.GetMag());
            Console.WriteLine("------------------------------------------");
            input = Console.ReadLine();

            input = input.ToLower();

            //Returns profession based on user input

            do
            {
                if (input[0] == 'w')
                {
                    chosenProf = new Warrior();
                    isValid = true;
                }
                else if (input[0] == 'm')
                {
                    chosenProf = new Mage();
                    isValid = true;
                }
                else if (input[0] == 'h')
                {
                    chosenProf = new Hunter();
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("This input is invalid, please try again!");
                    isValid = false;
                }
            } while (!isValid);

            return chosenProf;
        }

        //Asks user the difficulty level they wish to play.
        public static char GetDifficulty()
        {
            Console.Clear();
            
            string diff = "";

            Console.WriteLine("What difficulty would you like to play? (Easy, Medium, Hard)");
            diff = Console.ReadLine();

            diff = diff.ToLower();

            //Return the first character of the user input
            return diff[0];
        }

        //Code that runs through the game.
        public static void PlayGame()
        {
            string input = "";
            char direction = 'a';

            TheCave game = new TheCave();

            game.Reset();

            //Run through game

            Console.Clear();

            Console.WriteLine("Where would you like to go? (f, b, l, r)");
            input = Console.ReadLine();

            input = input.ToLower();

            direction = input[0];

            switch (direction)
            {
                case 'f':
                        Console.WriteLine("You have moved forward");
                        break;
                case 'b':
                        Console.WriteLine("You have moved backward");
                        break;
                case 'l':
                        Console.WriteLine("You have moved left");
                        break;
                case 'r':
                        Console.WriteLine("You have moved right");
                        break;
                default:
                        Console.WriteLine("This input is not valid. Please try again.");
                        break;
            }

            //Generate Map

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

        //Prints summary of the game.
        public static void PrintSummary(string ending)
        {
            //Base summary on choices within the game
            //2 Good endings
            //2 Bad endings

            //Show score

        }

        //Asks the user to play again.
        public static bool AskToPlayAgain()
        {
            string opt = "";

            Console.WriteLine("Play again if you dare! (Y/N)");
            opt = Console.ReadLine();

            //Returns a boolean that tells the program if the user wants to play again or not
            return (opt == "y" || opt == "Y");
        }
    }
}
