using System;
using System.Collections.Generic;
using System.Text;

namespace Console__game
{
    internal class Processing
    {
        public static void configErrorMessage(string firstMessage, string secondMessage)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;      // color Yellow text
            Console.Write($"{firstMessage}");
            Console.ForegroundColor = ConsoleColor.Red;         // color red text
            Console.WriteLine($" {secondMessage}\n");
            Console.ResetColor();                              // reset to default color
            Thread.Sleep(2000);
        }

        //public static void ApplyEffect (Character character, string effectName, int duration)
        //{
        //    if (character.effects.ContainsKey(effectName))
        //    {
        //        character.effects[effectName]["is"] = true;
        //        character.effects[effectName]["duration"] = duration;
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Effect {effectName} does not exist on character {character.Name}.");
        //    }
        //}

        public static void WriteWithDelay(string text, int charDelayMs = 50, int initialDelayMs = 0, bool endJump = true)
        {
            if (initialDelayMs > 0)
            {
                Thread.Sleep(initialDelayMs);
            }

            foreach (char c in text)
            {
                Console.Write(c);
                if (charDelayMs > 0)
                {
                    Thread.Sleep(charDelayMs);
                }
            }
            if (endJump) Console.WriteLine();
        }

        public static void welcoming(Character hero)
        {
            Thread.Sleep(1500);
            Console.Clear();
            WriteWithDelay($"Hmmm... ", 500, 1200);
            Console.Clear();
            WriteWithDelay($"{hero.Name}", charDelayMs: 60, 1200);
            WriteWithDelay($"Thats a great name!!!!", charDelayMs: 80, 1500);
            Thread.Sleep(1200);
            Console.Clear();
            WriteWithDelay($"Welcome thee valiant Hero. At last you are here! The World waited patiently for your arival.", charDelayMs: 80, 400); 
            WriteWithDelay($"Now when the day finaly come, we are unprepaired. We are sorry Hero. Enemy struck in our weak moment.", charDelayMs: 100, 600);
            WriteWithDelay($"What? You ask what happed? Thats a long story, you know.", charDelayMs: 120, 600);
            WriteWithDelay($"And Its always best to start ", charDelayMs: 140, 800, false);
            WriteWithDelay($"from begginig...... . .", charDelayMs: 280);

        }

        public static void loreDrop_0()
        {
            // Lorem ipsum lore story
            Thread.Sleep(1500);
            Console.Clear();
            WriteWithDelay($"In the ancient times, the world was a place of harmony and balance. ", charDelayMs: 60, 400);
            WriteWithDelay($"But as ages passed, darkness crept in, bringing chaos and despair. ", charDelayMs: 60, 800);
            WriteWithDelay($"Heroes rose to challenge the darkness, wielding powers beyond imagination. ", charDelayMs: 60, 800);
            WriteWithDelay($"Now, a new hero must emerge to restore balance and bring light back to the world. ", charDelayMs: 60, 800);
            Thread.Sleep(2000);
            Console.Clear();
        }

        public static void characterInfo(Character h)
        {
            Console.WriteLine($"\nHero {h.Name}, of powers:");
            Console.WriteLine($"HP: {h.HP}, Stamina: {h.Stamina}, Mana: {h.Mana}, Defense: {h.Defense}, Skill: {h.Skill}, Level: {h.Level}, Experience: {h.Experience}/{h.ExperienceToNextLevel}\n");
        }

        public static void characterChoosingProcess(Character h)
        {
            choose:
            try
            {
                Console.WriteLine($"What house of craft thy art in ? : ");
                Console.WriteLine($"/ 1 / Witcher");
                Console.WriteLine($"/ 2 / Sorcerer");
                Console.WriteLine($"/ 3 / Archer");
                Console.WriteLine($"/ 4 / Jarl");
                Console.WriteLine($"/ 5 / Bard");
                Console.WriteLine($"/ 6 / Monster");
                Console.WriteLine($"/ 7 / Dwarf");
                Console.Write("\n'Enter the number of your choice' : ");

                string choice = Console.ReadLine();
                Console.WriteLine();
                switch (choice.ToLower())
                {
                    case "1":
                        Console.WriteLine($"You have chosen the path of the Witcher!");
                        Witcher witcher = new Witcher(h.Name);
                        characterInfo(witcher);
                        break;
                    case "2":
                        Console.WriteLine($"You have chosen the path of the Sorcerer!");
                        Sorcerer sorcerer = new Sorcerer(h.Name);
                        characterInfo(sorcerer);
                        break;
                    case "3":
                        Console.WriteLine($"You have chosen the path of the Archer!");
                        Archer archer = new Archer(h.Name);
                        characterInfo(archer);
                        break;
                    case "4":
                        Console.WriteLine($"You have chosen the path of the Jarl!");
                        Jarl jarl = new Jarl(h.Name);
                        characterInfo(jarl);
                        break;
                    case "5":
                        Console.WriteLine($"You have chosen the path of the Bard!");
                        Bard bard = new Bard(h.Name);
                        characterInfo(bard);
                        break;
                    case "6":
                        Console.WriteLine($"You have chosen the path of the Monster!");
                        Monster monster = new Monster(h.Name);
                        characterInfo(monster);
                        break;
                    case "7":
                        Console.WriteLine($"You have chosen the path of the Dwarf!");
                        Dwarf dwarf = new Dwarf(h.Name);
                        characterInfo(dwarf);
                        break;
                    default:
                        configErrorMessage("Invalid choice:", " Please try again.");
                        goto choose;
                }
            }
            catch (ArgumentException ex)
            {
                configErrorMessage("Exception:", ex.Message);
                goto choose;
            }
        }
    }
}
