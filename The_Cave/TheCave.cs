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
        else if(difficulty == 'h')
        {
            maxTurns = 50;
        }

        return maxTurns;
    }
}