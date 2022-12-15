using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_project
{
    internal class CharacterClass
    {


        public static int[] CharacterClassSelection()
        {
            // hp atack mana gold speed
            while (true)
            {
                Console.WriteLine("Paladin - a \t Warrior -b \t Goblin -c \t Zlodziej -d \t Szybki goblin -e");
                string inp = Console.ReadLine();
                if (inp == "a")
                {
                    int[] m = { 100, 10, 300, 20, 0 };
                    return m;
                }
                else if (inp == "b")
                {
                    int[] w = { 300, 30, 0, 20, 0 };
                    return w;
                }
                else if (inp == "c")
                {
                    int[] w = { 200, 20, 150, 60, 0 };
                    return w;
                }
                else if (inp == "d")
                {
                    int[] w = { 50, 20, 0, 30, 1 };
                    return w;
                }
                else if (inp == "e")
                {
                    int[] w = { 1, 0, 0, 300, 600 };
                    return w;
                }
                else
                {
                    Console.WriteLine("Brak takiej klasy");
                }
            }
        }
        //---------------------------------------------------------
        public static bool isAlive(int[] character)
        {
            if (character[0] <= 0)
                return false;
            return true;
        }
    }
}
