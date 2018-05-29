using System;
using System.ComponentModel;

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

        public static object GetProfession()
        {
            Console.Clear();

            //Objects for stats

            Warrior war = new Warrior();
            Mage mage = new Mage();
            Hunter hun = new Hunter();

            //Input and validation variables

            object chosenProf;

            string input = "";
            bool isValid = false;

            do
            {
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

                if (input[0] == 'w')
                {
                    chosenProf = new Warrior();
                    return chosenProf;
                }
                else if (input[0] == 'm')
                {
                    chosenProf = new Mage();
                    return chosenProf;
                }
                else if (input[0] == 'h')
                {
                    chosenProf = new Hunter();
                    return chosenProf;
                }
                else
                {
                    Console.WriteLine("This input is invalid, please try again!");
                    return 0;
                }
            } while (!isValid);
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
            //Objects Declaration

            Random rand = new Random(DateTime.Now.Millisecond);
            TheCave game = new TheCave();

            //Get User Profession

            Type userProf = GetProfession();

            //Get the max amount of turns based on difficulty

            int maxTurns = game.GetTurns(GetDifficulty());

            Console.Clear();

            Console.WriteLine("You have {0} turns to escape! The cave might be merciful...then again...maybe not.", maxTurns);
            Console.WriteLine("Press enter to continue. Good Luck!");
            Console.ReadLine();

            Console.Clear();

            //Variable declarations

            // Can only hold a certain amount of items(Inventory)

            object[] inventory = new object[10]; 

            int randomNum = rand.Next(1, 100);
            int genMonster = 0;
            int genItem = 0;
            int fwd = 0;
            int right = 0;

            bool isValid = false;

            string input = "";

            for (int i = 0; i <= maxTurns; i++)
            {
                //Asks the user the direction they want to go in

                do
                {
                    Console.Write("Which direction would you like to go in? (f, b, l, r): ");
                    input = Console.ReadLine();

                    input = input.ToLower();

                    //Validates user input

                    if (input[0] == 'f' || input[0] == 'b' || input[0] == 'l' || input[0] == 'r')
                    {
                        isValid = true;
                    }
                    else
                    {
                        Console.WriteLine("Input invalid. Please try again.");
                        Console.WriteLine();
                        isValid = false;
                    }
                } while (isValid == false);

                //Allow the user to make decision as to where they go

                switch (input[0])
                {
                    case 'f':

                        Console.WriteLine("You moved forward!");
                        Console.WriteLine(genMonster);
                        fwd++;
                        break;

                    case 'b':

                        if (fwd == 0)
                        {
                            Console.WriteLine("You cant move back");
                        }
                        else
                        {
                            Console.WriteLine("You moved backwards");
                            fwd--;
                        }
                        break;

                    case 'l':

                        if (right == 0)
                        {
                            Console.WriteLine("You cant move left");
                        }
                        else
                        {
                            Console.WriteLine("You moved left");
                            right++;
                        }
                        break;

                    case 'r':

                        Console.WriteLine("You moved right");
                        right--;
                        break;
                }

                object[] enemArr = new object[10];

                Dragon drag = new Dragon();
                Warrior war = new Warrior();
                BattleAxe axe = new BattleAxe();
                Steel stlArm = new Steel();

                int enemAtk = drag.getAtk();
                int enemDef = drag.getDef();
                int enemHP = drag.getHP();
                int userHP = userProf.;
                int userAtk = axe.GetAtk();
                int userDef = axe.GetDef() + stlArm.GetDef();

                //Generate enemies

                genMonster += randomNum;

                if (genMonster >= 100)
                {
                    Console.WriteLine("You have to battle {0}", drag.getName());

                    for (int j = 0; j < 999; i++)
                    {
                        string userInput = "";

                        Console.WriteLine("What would you like to do? (Attack, Defend, Use Item, Run Away)");
                        userInput = Console.ReadLine().ToLower();

                        (int, int) battle = game.UserTurn(enemAtk, enemDef, enemHP, userAtk, userDef, userHP, userInput[0]);

                        userHP = battle.Item1;
                        enemHP = battle.Item2; 

                        if (battle.Item1 == -1 && battle.Item2 == -1)
                        {
                            genMonster = 0;
                            break;
                        }

                        if (drag.getHP() <= 0)
                        {
                            Console.WriteLine("You have successfully beaten the {0}", drag.getName());
                            genMonster = 0;
                            break;
                        }
                        else if (war.GetHealth() == 0)
                        {
                            Console.WriteLine("You have died.");
                            AskToPlayAgain();
                        }
                    }
                }
            }

            //TODO Assign objects where necessary

            //TODO Generate items around the area

            //Allow the use of objects where necessary
            //Give items certain boosts
            //Can drop item if necessary

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
