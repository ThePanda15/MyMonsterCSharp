using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ClassMonster
    {
        public int Id;
        public float Health;
        public string Race;
        public string Name;
        public int Age;
        public float Attack;
        Random ran = new Random();

        public string GetName()
        {
            int aleNum = ran.Next(1, 6);
            switch (aleNum)
            {
                case 1: return "Gamera";
                case 2: return "Zedus";
                case 3: return "King Kong";
                case 4: return "Godzilla";

                default: return "Faket";
            }

        }
        public string GetRace()
        {
            int aleNum = ran.Next(1, 6);
            switch (aleNum)
            {
                case 1: return "Ogro";
                case 2: return "Shinigami";
                case 3: return "Demon";
                case 4: return "Angel";
                default: return "Dios";

            }

        }
        public int GetAge()
        {
            return ran.Next(10, 1000);
        }

        public float GetHealth()
        {
            float rand = ran.Next(1, 102);
            float r = rand * 0.99f;
            return r;
        }

        public float GetAtack()
        {
            float rand2= ran.Next(1, 999);
            float  r2= rand2 * 0.99f;
            return r2;
        }
    }
}
