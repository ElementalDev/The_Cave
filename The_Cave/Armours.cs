using System;

//Initial class for all armours: Contains all methods of which the armours will use.
class Armours
{
    //Variables that will be used by all inherited classes.
    protected int armourDefPoints = 0;

    //Equips the armour to the player
    public char Equip()
    {
        Console.WriteLine("This armour has been equipped!");
        return 'e';
    }

    //Gets the defence of the armour
    public int GetDef() { return this.armourDefPoints; }
}

//Contains wool armour stats. Inherits from Armours.
class Wool : Armours
{
    public Wool()
    {
        armourDefPoints = 1;
    }
}

//Contains leather armour stats. Inherits from Armours.
class Leather : Armours
{
    public Leather()
    {
        armourDefPoints = 3;
    }
}

//Contains steel armour stats. Inherits from Armours.
class Steel : Armours
{
    public Steel()
    { 
        armourDefPoints = 5;
    }
}

//Contains chainmail armour stats. Inherits from Armours.
class Chainmail : Armours
{
    public Chainmail()
    {
        armourDefPoints = 8;
    }
}
