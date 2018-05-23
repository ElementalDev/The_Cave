namespace The_Cave
{
    class Professions
    {
        protected int healthPoints, magicPoints = 0;

        public void initialWeapon()
        {
            Dagger dgr = new Dagger();

        }

        public void initialArmour()
        {
            Leather le = new Leather();
        }

        public int GetHealth()
        {
            return this.healthPoints;

        }

        public int GetMag()
        {
            return this.magicPoints;
        }
    }

    class Warrior : Professions
    {
        public Warrior()
        {
            healthPoints = 40;
            magicPoints = 5;
        }
    }

    class Mage : Professions
    {
        public Mage()
        {
            healthPoints = 30;
            magicPoints = 20;
        }
    }

    class Hunter : Professions
    {
        public Hunter()
        {
            healthPoints = 50;
            magicPoints = 10;
        }
    }
}
