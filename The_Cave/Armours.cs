using System;

namespace The_Cave
{
    class Armours
    {
        protected int armourDefPoints = 0;

        public char Equip()
        {
            Console.WriteLine("This armour has been equipped!");
            return 'e';
        }

        public int GetDef()
        {
            return this.armourDefPoints;
        }

    }

    class Leather : Armours
    {
        public Leather()
        {
            armourDefPoints = 3;
        }
    }

    class Steel : Armours
    {
        public Steel()
        { 
            armourDefPoints = 5;
        }
    }


    class Wool : Armours
    {
        public Wool()
        {
            armourDefPoints = 1;
        }
    }


    class Chainmail : Armours
    {
        public Chainmail()
        {
            armourDefPoints = 8;
        }
    }
}
