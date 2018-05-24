//Initial Class for all professions: Contains all methods of which the professions will use.
class Professions
{
    //Variables that will be used by all inherited classes.
    protected int healthPoints, magicPoints = 0;

    //Gives professions a weapon to start with.
    public void InitialWeapon() { Dagger dgr = new Dagger(); }

    //Gives professions a weapon to start with.
    public void InitialArmour() { Wool wool = new Wool(); }

    //Gets the health of the professions.
    public int GetHealth() { return this.healthPoints; }

    //Gets the amount of magic of the professions.
    public int GetMag() { return this.magicPoints; }
}

//Contains warrior stats. Inherits from Professions.
class Warrior : Professions
{
    public Warrior()
    {
        healthPoints = 40;
        magicPoints = 5;
    }
}

//Contains mage stats. Inherits from Professions.
class Mage : Professions
{
    public Mage()
    {
        healthPoints = 30;
        magicPoints = 20;
    }
}

//Contains hunter stats. Inherits from Professions.
class Hunter : Professions
{
    public Hunter()
    {
        healthPoints = 50;
        magicPoints = 10;
    }
}

