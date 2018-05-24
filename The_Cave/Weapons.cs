using System;

//Initial class for all weapons: Contains all methods of which the weapons will use.
class Weapons
{
    //Variables that will be used by all inherited classes.
    protected int atkPoints, wepDefPoints = 0;

    //Equips the weapon to the player
    public char Equip()
    {
            Console.WriteLine("This armour has been equipped!");
            return 'e';
    }

    //Gets the attack of the weapon
    public int GetAtk() { return this.atkPoints; }

    //Gets the defence of the weapon
    public int GetDef() { return this.wepDefPoints; }
}

//Contains dagger stats. Inherits from Weapons.
class Dagger : Weapons
{
    public Dagger()
    {
        atkPoints = 2;
        wepDefPoints = 2;
    }
}

//Contains crossbow stats. Inherits from Weapons.
class CrossBow : Weapons
{
    public CrossBow()
    {
        atkPoints = 6;
        wepDefPoints = 1;
    }
}

//Contains mace stats. Inherits from Weapons.
class Mace : Weapons
{
    public Mace()
    {
        atkPoints = 6;
        wepDefPoints = 4;
    }
}

//Contains morning star stats. Inherits from Weapons.
class MorningStar : Weapons
{
    public MorningStar()
    {
        atkPoints = 8;
        wepDefPoints = 2;
    }
}

//Contains longsword. Inherits from Weapons.
class Longsword : Weapons
{
    public Longsword()
    {
        atkPoints = 6;
        wepDefPoints = 3;
    }
}

//Contains battle axe stats. Inherits from Weapons.
class BattleAxe : Weapons
{
    public BattleAxe()
    {
        atkPoints = 5;
        wepDefPoints = 4;
    }
}
