class Enemies
{
    protected int healthPoints = 0, atkPoints = 0, defPoints = 0, magicPoints = 0;
    protected string enemName = "";

    public int getHP() { return healthPoints; }

    public int getAtk() { return atkPoints; }

    public int getDef() { return defPoints; }

    public int getMP() { return magicPoints; }

    public string getName() { return enemName; }
}

class Dragon : Enemies
{
    public Dragon()
    {
        enemName = "Dragon";
        healthPoints = 20;
        atkPoints = 10;
        defPoints = 10;
        magicPoints = 0;
    }
}


