using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_project
{
    public class Shop
    {
        public static int[] shop(int[] character, int mxaHp, int maxMana)
        {
            Console.WriteLine("Witaj w moim sklepie!!!");
            Console.WriteLine("1 - heal 2g \t 2 - upAtac 3g \t 3 - upMana 3g \t dowolny klawisz - wyjdz");

            int inp = int.Parse(Console.ReadLine());
            switch (inp)
            {
                case 1:
                    return heal(character, mxaHp);
                case 2:
                    return upAtac(character);
                case 3:
                    return upMana(character);
            }
            Console.WriteLine("Wychodzisz ze sklepu");
            return character;
        }

        public static int[] heal(int[] character, int mxaHp)
        {
            Random rnd = new Random();
            int heal = rnd.Next(10,20);
            Console.WriteLine(character[0]);
            if (character[3] >= 2)
            {
                Console.WriteLine("Płacisz 2 g");
                character[3] -= 2;
                if (character[0] + heal >= mxaHp)
                {
                    Console.WriteLine("Masz max hp");
                    character[0] = mxaHp;
                    return character;
                }
                else 
                {
                    Console.WriteLine($"uleczono cie o {heal} masz {character[0]}hp");
                    character[0] += heal;
                    return character;
                }
            }
            Console.WriteLine("Nie stac sie");
            return character;
        }


        public static int[] upAtac(int[] character)
        {
            if (character[3] >= 10)
            {
                Console.WriteLine("Twoj atak zwiekszyl sie o 5 wydajesz 10 zlota");
                character[3] -= 10;
                character[1] += 5;
            }
            else
            {
                Console.WriteLine("Nie masz wystarczjaco goolda");
            }
            return character;
        }

        public static int[] upMana(int[] character)
        {
            if (character[3] >= 10)
            {
                Console.WriteLine("Twoja mana zwiszkyla sie o 50 wydajesz 10 zlota");
                character[3] -= 10;
                character[2] += 50;
            }
            else
            {
                Console.WriteLine("Nie masz wystarczjaco goolda");
            }
            return character;
        }
    }
}
