using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_project
{
    internal class Run
    {
        static void Main(string[] args)
        {
            // hp atack mana gold 
             int[] character = CharacterClass.CharacterClassSelection();
            int round = 0;

            int maxHp = character[0];
            int maxMana = character[2];

            while (CharacterClass.isAlive(character))
            {
                GameInformation.informations(character, round);
                string inp = Console.ReadLine().ToLower();
                switch (inp)
                {
                    case "a":
                        Console.WriteLine("Wlaka");
                        Monsters.Faight(character);
                        break;
                    case "s":
                        Console.WriteLine("Spele");
                        Spels.SpelsBook(character, maxHp, maxMana);
                        break;
                    case "w":
                        Shop.shop(character, maxHp, maxMana);
                        Console.WriteLine("Sklep");
                        break;
                    default:
                        Console.WriteLine("Taka komenda nie istnieje");
                        break;
                }
                round += 1;
            }

            Console.WriteLine("Dziekuje za gre");
            Console.ReadKey();
        }
    }
}
