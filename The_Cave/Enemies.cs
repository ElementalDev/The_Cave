//Initialise the type for all enemies
class Enemies
{
    protected int healthPoints = 0, atkPoints = 0, defPoints = 0, magicPoints = 0;
    protected string enemName = "";

    public int GetHP() { return healthPoints; }

    public int GetAtk() { return atkPoints; }

    public int GetDef() { return defPoints; }

    public int GetMP() { return magicPoints; }

    public string GetName() { return enemName; }
}

//Types of enemies
class Dragon : Enemies
{
    public Dragon()
    {
        enemName = "Dragon";
        healthPoints = 100;
        atkPoints = 20;
        defPoints = 20;
        magicPoints = 0;
    }
}

class Wraith : Enemies
{
    public Wraith()
    {
        enemName = "Wraith";
        healthPoints = 30;
        atkPoints = 10;
        defPoints = 10;
        magicPoints = 10;
    }
}

class Giant : Enemies
{
    public Giant()
    {
        enemName = "Giant";
        healthPoints = 50;
        atkPoints = 20;
        defPoints = 20;
        magicPoints = 0;
    }
}

class Goblin : Enemies
{
    public Goblin()
    {
        enemName = "Goblin";
        healthPoints = 10;
        atkPoints = 5;
        defPoints = 5;
        magicPoints = 15;
    }
}

class Skeleton : Enemies
{
    public Skeleton()
    {
        enemName = "Skeleton";
        healthPoints = 20;
        atkPoints = 10;
        defPoints = 10;
        magicPoints = 0;
    }
}

class Giant_Bat : Enemies
{
    public Giant_Bat()
    {
        enemName = "Giant Bat";
        healthPoints = 10;
        atkPoints = 5;
        defPoints = 5;
        magicPoints = 0;
    }
}


