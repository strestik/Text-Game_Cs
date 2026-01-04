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
                string name = Console.ReadLine();
                Character Hero = new Character(name);
                //Console.WriteLine($"Character Created: {hero.Name}");
                //Console.WriteLine($"HP: {hero.HP}, Stamina: {hero.Stamina}, Mana: {hero.Mana}, Defense: {hero.Defense}, Skill: {hero.Skill}, Level: {hero.Level}, Experience: {hero.Experience}/{hero.ExperienceToNextLevel}");
                welcoming(Hero);
                loreDrop_1();
            }
            catch (ArgumentException ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;      // color DarkRed text
                Console.Write($"Exception:");
                Console.ForegroundColor = ConsoleColor.Red;         // color red text
                Console.WriteLine($" {ex.Message}\n");
                Console.ResetColor();                              // reset to default color
                Thread.Sleep(2000);
                goto Start;
            }

            Console.ReadKey();
        }
    }
}
