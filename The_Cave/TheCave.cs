using System;

class TheCave
{
    private static int maxTurns = 0;

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

    public (int, int) UserTurn(int enemAtk, int enemDef, int enemHP, int userAtk, int userDef, int userHP, char userInput)
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

                return (-1, -1);
        }

        return (userHP, enemHP);

    }

    public (int, int) EnemTurn(int enemAtk, int enemDef, int enemHP, int userAtk, int userDef, int userHP)
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

        return (userHP, enemHP);

    }

    public void UseItem()
    {

    }
}

       