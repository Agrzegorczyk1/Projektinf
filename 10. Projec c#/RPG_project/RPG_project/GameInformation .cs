using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RPG_project
{
    internal class GameInformation
    {
        public static void informations(int[] charcer, int round)
        {
            Console.WriteLine($"------------------- round - {round} -------------------");
            Console.WriteLine($"Twoje hp {charcer[0]} atak {charcer[1]} mana {charcer[2]}  goold {charcer[3]}");
            Console.WriteLine($"======================================\n" +
                $"_   a - go to adventure              _\n" +
                $"_   s - spells                       _\n" +
                $"_   w- shop                          _" +
                $"\n======================================");
            Thread.Sleep(900); 
        }


    }
}
