using System;

class TheCave
{
    private static int maxTurns = 0;

    //Constructor

    public TheCave()
    {
        Reset();
    }

    public void Reset()
    {
        Weapons wep = new Weapons();
        Armours arm = new Armours();
        Professions prof = new Professions();
    }

    //Asks user the difficulty level they wish to play.
    public char GetDifficulty()
    {
        Console.Clear();

        string diff = "";

        Console.WriteLine("What difficulty would you like to play? (Easy, Medium, Hard)");
        diff = Console.ReadLine();

        diff = diff.ToLower();

        //Return the first character of the user input
        return diff[0];
    }

    //Uses difficulty to determine the amount of turns

    public int GetTurns(char difficulty)
    {

        if (difficulty == 'e')
        {
            maxTurns = 110;
        }
        else if (difficulty == 'm')
        {
            maxTurns = 75;
        }
        else if (difficulty == 'h')
        {
            maxTurns = 50;
        }

        return maxTurns;
    }

    //Ask the user what profession they want to use.

    public Professions GetProfession()
    {
        Console.Clear();

        //Objects for stats

        Warrior war = new Warrior();
        Mage mage = new Mage();
        Hunter hun = new Hunter();

        //Input and validation variables

        Professions chosenProf;

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
                return null;
            }
        } while (!isValid);
    }

    //Works out battle stats for each turn

    public int UserTurn(int enemAtk, int enemDef, int enemHP, int userAtk, int userDef, int userHP, char userInput)
    {
        switch (userInput)
        {
            //When user attackes the enemy

            case 'a':

                if (userAtk > enemDef)
                {
                    Console.WriteLine("You have damaged the enemy!");
                    enemHP -= (userAtk - enemDef);
                    Console.WriteLine("Enemies HP is now: {0}", userHP);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("No damage has been inflicted");
                    Console.ReadLine();
                }
                break;

            //When enemy attacks user

            case 'd':

                EnemTurn(enemAtk, enemDef, enemHP, userAtk, userDef, userHP);
                break;

            case 'u':

                UseItem();
                break;

            case 'r':

                return -1;
        }

        return userHP;

    }

    public int EnemTurn(int enemAtk, int enemDef, int enemHP, int userAtk, int userDef, int userHP)
    {
        //When enemy attacks user

        if (enemAtk > userDef)
        {
            Console.WriteLine("You have taken damage");
            userHP -= (enemAtk - userDef);
            Console.WriteLine("You HP is now: {0}", userHP);
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("No damage has been taken");
            Console.ReadLine();
        }

        return enemHP;

    }

    public void UseItem()
    {

    }
}

       