using System;
using System.Collections.Generic;
using System.Threading;

namespace Text_Game_CS
{
    internal class Program : Processing
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    // // Proces of choosing character class, states specific stats and abilities of each class, and then choosing the class

                    Character Hero = characterChoosingProcess(enter());                      // Create the hero character with the provided name

                    Character Enemy = enemyCharacterChoosingProcess();                             // Create an enemy character for the first encounter
                    
                    if (Processing.skip())
                    {
                        // // Welcoming the player and introducing the game world
                        welcoming(Hero);

                        // // Starting lore drop, first encounter and proposition of lore
                        loreDrop_0();
                    } // Text part

                    // temporary print
                    Console.WriteLine("Beware, your enemy is not so easy to read. Its posible that you dont know all, but every time gather data you know more and more. . .");
                    enemyInfo(Enemy); // Show the enemy's information before the fight

                    // // Introdusing stats, abbilities and equpment , ascii art for difrent classes


                    Character.Death();
                    Thread.Sleep(2000);
                    break;
                }
                catch (Exception ex)
                {
                    configErrorMessage("Exception: ", ex.Message);
                    Console.Clear();
                }
            }

            Console.ReadKey();
        }
    }
}
