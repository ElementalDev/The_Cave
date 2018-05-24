using System;

namespace The_Cave
{
    class Weapons
    {
        protected int atkPoints, wepDefPoints = 0;

        public char Equip()
        {
            Console.WriteLine("This armour has been equipped!");
            return 'e';
        }

        public int GetAtk()
        {
            return this.atkPoints;

        }

        public int GetDef()
        {
            return this.wepDefPoints;
        }
    }

    class Dagger : Weapons
    {
        public Dagger()
        {
            atkPoints = 2;
            wepDefPoints = 2;
        }
    }

    class CrossBow : Weapons
    {
        public CrossBow()
        {
            atkPoints = 6;
            wepDefPoints = 1;
        }
    }

    class Mace : Weapons
    {
        public Mace()
        {
            atkPoints = 6;
            wepDefPoints = 4;
        }
    }

    class MorningStar : Weapons
    {
        public MorningStar()
        {
            atkPoints = 8;
            wepDefPoints = 2;
        }
    }

    class Longsword : Weapons
    {
        public Longsword()
        {
            atkPoints = 6;
            wepDefPoints = 3;
        }
    }

    class BattleAxe : Weapons
    {
        public BattleAxe()
        {
            atkPoints = 5;
            wepDefPoints = 4;
        }
    }
}
