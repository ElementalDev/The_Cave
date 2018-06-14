using System;

class TheCave
{
    private static int maxTurns;

    //Constructor

    public TheCave()
    {
        maxTurns = 0;
    }

    public Enemies[] InitEnemies()
    {
        Enemies[] enemArr = new Enemies[6];

        enemArr[0] = new Goblin();
        enemArr[1] = new Giant_Bat();
        enemArr[2] = new Giant();
        enemArr[3] = new Wraith();
        enemArr[4] = new Skeleton();
        enemArr[5] = new Dragon();

        return enemArr;
    }

    public Weapons[] InitWeapons()
    {
        Weapons[] wepArr = new Weapons[6];

        wepArr[0] = new Dagger();
        wepArr[1] = new CrossBow();
        wepArr[2] = new Mace();
        wepArr[3] = new MorningStar();
        wepArr[4] = new Longsword();
        wepArr[5] = new BattleAxe();

        return wepArr;
    }

    public Armours[] InitArmours()
    {
        Armours[] armArr = new Armours[4];

        armArr[0] = new Wool();
        armArr[1] = new Leather();
        armArr[2] = new Steel();
        armArr[3] = new Chainmail();

        return armArr;
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

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("|Which profession would you like to be?|");
            Console.WriteLine("|          (Type your selection)       |");
            Console.WriteLine("|                                      |");
            Console.WriteLine("|     - Warrior - HP= {0}, MP= {1}     |", war.GetHealth(), war.GetMag());
            Console.WriteLine("|     - Mage - HP= {0}, MP= {1}        |", mage.GetHealth(), mage.GetMag());
            Console.WriteLine("|     - Hunter -  HP= {0}, MP= {1}     |", hun.GetHealth(), hun.GetMag());
            Console.WriteLine("----------------------------------------");
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

                string itemUsed = UseItem(userAtk, userDef, userHP);

                if(itemUsed == "lh" || itemUsed == "h")
                {
                    Console.WriteLine("Your new health is: {0}", userHP);
                }
                else if (itemUsed == "a")
                {
                    Console.WriteLine("Your new atk is: {0}", userAtk);
                }
                else if (itemUsed == "d")
                {
                    Console.WriteLine("Your new def is: {0}", userDef);
                }
                else
                {
                    break;
                }
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

    public string UseItem(int userAtk, int userDef, int userHP)
    {
        string itemSelection = String.Empty;

        Console.WriteLine("Which item would you like to use?");
        itemSelection = Console.ReadLine();

        itemSelection = itemSelection.ToLower();

        if (itemSelection[0] == 'l' && itemSelection[1] == 'h')
        {
            userHP += 50;

            return "lh";
        }
        else if (itemSelection[0] == 'h')
        {
            userHP += 15;
            return "h";
        }
        else if (itemSelection[0] == 'a')
        {
            userAtk += 5;
            return "a";
        }
        else if (itemSelection[0] == 'd')
        {
            userDef += 5;
            return "d";
        }
        else
        {
            Console.WriteLine("This item does not exist");
            return "0";
        }
    }
}

       