using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_project
{
    internal class Spels
    {
        public static int[] SpelsBook(int[] character, int mxaHp, int maxMana)
        {
            Console.WriteLine("a - Lecznie  b - zwiększ atak");
            string inp = Console.ReadLine().ToLower();
            switch (inp)
            {
                case "a":
                    return Heal(character, mxaHp, maxMana);
                default:
                    return character;
                case "b":
                    return upAtac(character, maxMana);
                case "c":
                    return upAtac(character, maxMana);



            }
        }

        public static int[] Heal(int[] character, int mxaHp, int maxMana)
        {
            if (character[2] >= 100)
            {
                character[0] = mxaHp;
                character[2] -= 100;
                Console.WriteLine("Masz max hp");
                return character;
            }
            else
            {
                Console.WriteLine("Brak many");
            }

            return character;
        }
        public static int[] upAtac(int[] character, int maxMana)
        {
            {
                if (character[2] >= 20)
                {
                    character[1] += 5;
                    character[2] -= 20;
                    Console.WriteLine("dostajesz +5 atk");
                    return character;
                }
                else
                {
                    Console.WriteLine("Brak many");
                }



                return character;
            }





        }
    }
}
