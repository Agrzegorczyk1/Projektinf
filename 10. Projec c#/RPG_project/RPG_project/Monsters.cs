using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace RPG_project
{
    internal class Monsters
    {

        public static int[] genrateMonster()
        {
            Random rnd = new Random();
            int[] monsterStatystic = new int[4];
            for (int i = 0; i < monsterStatystic.Length; i++)
            {
                monsterStatystic[i] = rnd.Next(20,30);
            }
            return monsterStatystic;
        }

        public static int[] genrateMonster2()
        {
            Random rnd = new Random();
            int[] monsterStatystic = new int[4];
            for (int i = 0; i < monsterStatystic.Length; i++)
            {
                monsterStatystic[i] = rnd.Next(30, 60);
            }
            return monsterStatystic;
        }



        public static int[] Faight(int[] player)
        {
            Console.WriteLine("Spotykasz potwora");
            int[] monster = genrateMonster();
            while (monster[0] > 0)
            {
                if (player[4] > 0) 
                {
                    player[0] -= monster[1];
                    monster[0] -= player[1];
                }
                else
                { monster[0] -= player[1];
                  player[0] -= monster[1];
                }



                    if (player[0] <= 0)
                        
                       
                {
                    Console.WriteLine("Umierasz w cierpieaniach !!!");
                    break;

                }
                Thread.Sleep(900);
                if (player[4] < 1)
                {
                    Console.WriteLine($"Walka playerHp {player[0]} dostjesz {monster[1]} obr = monster {player[0]} zadajesz {player[1]}");
                }
                else
                { 
                    Console.WriteLine($"monster {player[0]} zadajesz {player[1]} = Walka playerHp {player[0]} dostjesz {monster[1]} obr");
                }

            }
            player[3] += monster[3];
            return player;

        }



    }
}
