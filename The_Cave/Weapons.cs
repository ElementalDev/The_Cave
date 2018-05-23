using System;

namespace The_Cave
{
    class Weapons
    {
        protected int atkPoints, defPoints = 0;

        public int Attack(int opDef)
        {
            if (atkPoints < opDef)
            {
                Console.WriteLine("your weapon is not strong enough! No damage done.");
                return 0;
            }
            else if (atkPoints > opDef)
            {
                Console.WriteLine("You have wounded your enemy!");
                return atkPoints - opDef;
            }
            else
            {
                Console.WriteLine("You are both as strong as eachother.");
                return 0;
            }
        }

        public int Defend(int opAtk, int armourDef)
        {
            if ((defPoints + armourDef) < opAtk)
            {
                Console.WriteLine("Your defense was broken, you have been hurt!");
                return opAtk - defPoints;
            }
            else if ((defPoints + armourDef) > opAtk)
            {
                Console.WriteLine("You have successfully defended!");
                return 0;
            }
            else
            {
                Console.WriteLine("You are both as strong as eachother.");
                return 0;
            }
        }

        public int GetAtk()
        {
            return this.atkPoints;

        }

        public int GetDef()
        {
            return this.defPoints;
        }
    }

    class Dagger : Weapons
    {
        public Dagger()
        {
            atkPoints = 3;
            defPoints = 3;
        }
    }

    class CrossBow : Weapons
    {
        public CrossBow()
        {
            atkPoints = 6;
            defPoints = 1;
        }
    }

    class Mace : Weapons
    {
        public Mace()
        {
            atkPoints = 6;
            defPoints = 4;
        }
    }

    class MorningStar : Weapons
    {
        public MorningStar()
        {
            atkPoints = 8;
            defPoints = 2;
        }
    }

    class Longsword : Weapons
    {
        public Longsword()
        {
            atkPoints = 6;
            defPoints = 3;
        }
    }

    class BattleAxe : Weapons
    {
        public BattleAxe()
        {
            atkPoints = 5;
            defPoints = 4;
        }
    }
}
