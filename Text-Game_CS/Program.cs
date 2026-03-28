using System;
using System.Collections.Generic;
using System.Threading;

namespace Text_Game_CS
{
    internal class Program : Processing
    {
        static void Main(string[] args)
        {
            Processing p = new Processing();
            while (true)
            {
                try
                {
                    // // Proces of choosing character class, states specific stats and abilities of each class, and then choosing the class

                    Character Hero = p.characterChoosingProcess(p.enter());                      // Create the hero character with the provided name

                    Character Enemy = p.enemyCharacterChoosingProcess();                             // Create an enemy character for the first encounter
                    
                    if (p.skip())
                    {
                        // // Welcoming the player and introducing the game world
                        p.welcoming(Hero);

                        // // Starting lore drop, first encounter and proposition of lore
                        p.loreDrop_0();
                    } // Text part

                    // temporary print
                    Console.WriteLine("Beware, your enemy is not so easy to read. Its posible that you dont know all, but every time gather data you know more and more. . .");
                    p.enemyInfo(Enemy); // Show the enemy's information before the fight

                    // // Introdusing stats, abbilities and equpment , ascii art for difrent classes


                    Hero.Death();
                    Thread.Sleep(2000);
                    break;
                }
                catch (Exception ex)
                {
                    p.configErrorMessage("Exception: ", ex.Message);
                    Console.Clear();
                }
            }

            Console.ReadKey();
        }
    }
}
