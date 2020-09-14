using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ClassArena
    {
        public DateTime fecha;
        public int p1, p2;
        public int winner;

        public int Fight(ClassMonster[] myMonster)
        {

            myMonster[p1 - 1].Health = myMonster[p1 - 1].Health - myMonster[p2 - 1].Attack;
            myMonster[p2 - 1].Health = myMonster[p2 - 1].Health - myMonster[p1 - 1].Attack;
            if (myMonster[p1 - 1].Health > myMonster[p2 - 1].Health)
            {
                return p1;
            }
            else
            {
                return p2;
            }
        }
    }
}
