using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassMonster[] monsters = new ClassMonster[10];
            ClassArena[] battle = new ClassArena[5];
            Console.WriteLine(" **********¡Monstruos!********** ");
            for (int i = 0; i < monsters.Length; i++)
            {
                monsters[i] = new ClassMonster();
                monsters[i].Id = i + 1;
                monsters[i].Name = monsters[i].GetName();
                monsters[i].Race = monsters[i].GetRace();
                monsters[i].Age = monsters[i].GetAge();
                monsters[i].Health = monsters[i].GetHealth();
                monsters[i].Attack = monsters[i].GetAtack();
                Console.WriteLine("\nID: " + monsters[i].Id + "\nName: " + monsters[i].Name + "\nRace: " + monsters[i].Race + "\nAge: " + monsters[i].Age + "\nHealth: " + monsters[i].Health + "\nAtack: " + monsters[i].Attack);
                Console.ReadLine();
            }
            Console.WriteLine("**********************************************************\n");
            for (int i = 0; i < battle.Length; i++)
            {
                battle[i] = new ClassArena();
                battle[i].fecha = DateTime.Today;
                Console.WriteLine("***********************************************************");
                Console.WriteLine("\n              C O M B A T E "+ (i + 1)+"                   ");
                Console.WriteLine("Elije monstruo para jugador 1: ");
                battle[i].p1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Elije monstruo para jugador 2: ");
                battle[i].p2 = int.Parse(Console.ReadLine());

                battle[i].winner = battle[i].Fight(monsters);
                Console.WriteLine("\nFecha: " + battle[i].fecha);
                Console.WriteLine("-->Player 1: " + "\nNumero de monstruo: " + battle[i].p1 + "\nHealth: " + monsters[battle[i].p1 - 1].Health + "\nAtack: " + monsters[battle[i].p1 - 1].Attack+"\n");
                Console.WriteLine("-->Player 2: " + "\nNumero de monstruo: " + battle[i].p2 + "\nHealth: " + monsters[battle[i].p2 - 1].Health + "\nAtack: " + monsters[battle[i].p2 - 1].Attack);
                Console.WriteLine("\n Gana el monstruo " + battle[i].Fight(monsters));
            }
            Console.ReadLine();
        }
    }
}
