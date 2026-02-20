using System;
using System.Collections.Generic;
using Character = Console__game.Character;
using System.Threading;

namespace Console__game
{
    internal class Program : Processing
    {
        static void Main(string[] args)
        {
            Start:
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
            }
            catch (ArgumentException ex)
            {
                configErrorMessage("Exception:", ex.Message);
                goto Start;
            }

            Console.ReadKey();
        }
    }
}
