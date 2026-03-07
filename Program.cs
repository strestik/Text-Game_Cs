using System;
using System.Collections.Generic;
using System.Threading;

namespace Console__game
{
    internal class Program : Processing
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter your character's name : ");
                    string input = Console.ReadLine();
                    Console.WriteLine();
                    Character Hero = new Character(input);                              // Create the hero character with the provided name

                    // // Welcoming the player and introducing the game world
                    // welcoming(Hero);

                    // // Starting lore drop, first encounter and proposition of lore
                    // loreDrop_0();

                    // // Proces of choosing character class, states specific stats and abilities of each class, and then choosing the class
                    characterChoosingProcess(Hero);

                    // // Introdusing stats, abbilities and equpment
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
