using System;
using System.Collections.Generic;
using Character = Console__game.Character;

namespace Console__game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Character hero = new Character("");
                Console.WriteLine($"Character Created: {hero.Name}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            
            


            Console.ReadKey();
        }
    }
}
