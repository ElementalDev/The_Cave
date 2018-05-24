namespace The_Cave
{
    class TheCave
    {
        public void Reset()
        {
            Weapons wep = new Weapons();
            Armours arm = new Armours();
            Professions prof = new Professions();
            Enemies enem = new Enemies();
        }

        public object[,] MapCreate(char difficulty)
        {
            object[,] Map = new string[0, 0];

            if (difficulty == 'e')
            {
                Map = new string[10, 10];
            }
            else if (difficulty == 'm')
            {
                Map = new string[25, 25];
            }
            else if (difficulty == 'h')
            {
                Map = new string[40, 40];
            }

            return Map;
        }
    }
}
