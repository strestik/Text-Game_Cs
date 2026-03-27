using System;
using System.Collections.Generic;
using System.Text;

namespace Text_Game_CS
{
    internal class Processing
    {
        public static Random rand = new Random();
        private static Dictionary<string, bool> enemyShow = new Dictionary<string, bool>() 
        {   
            ["showHp"] = false ,
            ["showStamina"] = false,
            ["showMana"] = false,
            ["showDefense"] = false,
            ["showSkill"] = false,
            ["showLevel"] = false
        };
        public static string bookASCII = $"                .-~~~~~~~~~-._       _.-~~~~~~~~~-.\r\n            __.'              ~.   .~              `.__\r\n          .'//                  \\./                  \\\\`.\r\n        .'//                     |                     \\\\`.\r\n      .'// .-~\"\"\"\"\"\"\"~~~~-._     |     _,-~~~~\"\"\"\"\"\"\"~-. \\\\`.     Unknown\r\n    .'//.-\"                 `-.  |  .-'                 \"-.\\\\`.\r\n  .'//______.============-..   \\ | /   ..-============.______\\\\`.\r\n.'______________________________\\|/______________________________`.";
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

        public static bool skip()
        {
            Thread.Sleep(1000);
            if (Console.KeyAvailable && Console.ReadKey(intercept: true).Key == ConsoleKey.Enter) return false;
            return true;
        }
        public static string enter()
        {
            Console.WriteLine("___________________________");
            Console.Write("Enter your character's name : ");
            string input = Console.ReadLine();
            Console.WriteLine();
            return input;
        }

        public static void characterInfo(Character h)
        {
            Console.Clear();
            Console.WriteLine($"\nHero {h.Name}, of powers:");
            Console.WriteLine($"HP: {h.HP}, Stamina: {h.Stamina}, Mana: {h.Mana}, Defense: {h.Defense}, Skill: {h.Skill}, Level: {h.Level}, Experience: {h.Experience}/{h.ExperienceToNextLevel}\n");
        }

        public static void enemyInfo(Character e)  // info about enemy with propability for eatch info
        {
            // if ifno is not yet known, then there is 70% chance to show it, otherwise it will be shown
            if (!enemyShow["showHp"]) enemyShow["showHp"] = rand.Next(100) > 30;
            if (!enemyShow["showStamina"]) enemyShow["showStamina"] = rand.Next(100) > 30;
            if (!enemyShow["showMana"]) enemyShow["showMana"] = rand.Next(100) > 30;
            if (!enemyShow["showDefense"]) enemyShow["showDefense"] = rand.Next(100) > 30;
            if (!enemyShow["showSkill"]) enemyShow["showSkill"] = rand.Next(100) > 30;
            if (!enemyShow["showLevel"]) enemyShow["showLevel"] = rand.Next(100) > 30;


            Console.Clear();
            Console.WriteLine($"\nEnemy {e.Name}, of powers:");
            if (enemyShow["showHp"]) Console.Write($"HP: {e.HP}, ");
            if (enemyShow["showStamina"]) Console.Write($"Stamina: { e.Stamina}, ");
            if (enemyShow["showMana"]) Console.Write($"Mana: { e.Mana}, ");
            if (enemyShow["showDefense"]) Console.Write($"Defense: { e.Defense}, ");
            if (enemyShow["showSkill"]) Console.Write($"Skill: { e.Skill}, ");
            if (enemyShow["showLevel"]) Console.Write($"Level: { e.Level}\n");
            Console.WriteLine($"");
            Console.WriteLine($"Click any button to continue...");
            Console.ReadKey();
        }

        public static void welcoming(Character hero)
        {
            if (skip())
            {
                Thread.Sleep(1000);
                Console.Clear();
                WriteWithDelay($"Hmmm... ", 500, 1200);
                Console.Clear();
                WriteWithDelay($"{hero.Name}", charDelayMs: 60, 1200);
                WriteWithDelay($"Thats a great name!!!!", charDelayMs: 80, 1500);
                Thread.Sleep(1200);
                Console.Clear();
                WriteWithDelay($"Welcome thy valiant Hero. At last you are here! The World waited patiently for your arival.", charDelayMs: 80, 400);
                WriteWithDelay($"Now when the day finaly come, we are unprepaired. We are sorry Hero. Enemy struck in our weak moment.", charDelayMs: 100, 600);
                WriteWithDelay($"What? You ask what happed? Thats a long story, you know.", charDelayMs: 120, 600);
                WriteWithDelay($"And Its always best to start ", charDelayMs: 140, 800, false);
                WriteWithDelay($"from begginig...... . .", charDelayMs: 280);
            }
        }

        public static void loreDrop_0()
        {
            // Lorem ipsum lore story
            if (skip())
            {
                Thread.Sleep(1500);
                Console.Clear();
                WriteWithDelay($"In the ancient times, the world was a place of harmony and balance. ", charDelayMs: 60, 400);
                WriteWithDelay($"But as ages passed, darkness crept in, bringing chaos and despair. ", charDelayMs: 60, 800);
                WriteWithDelay($"Heroes rose to challenge the darkness, wielding powers beyond imagination. ", charDelayMs: 60, 800);
                WriteWithDelay($"Now, a new hero must emerge to restore balance and bring light back to the world. ", charDelayMs: 60, 800);
                Thread.Sleep(2000);
                Console.Clear();
            }
        }

        public static Character characterChoosingProcess(string name)
        {
            while (true)
            {
                try
                {
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.WriteLine($"What house of craft thy art in ? : \n");
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
                            Console.WriteLine($"Oh... I see, you have chosen the path of the Witcher!");
                            Character witcher = new Witcher(name);
                            Thread.Sleep(1500);

                            characterInfo(witcher);
                            Console.WriteLine("\nPress any key to continue...\n");
                            Console.ReadKey();

                            return witcher;


                        case "2":
                            Console.WriteLine($"Oh... I see, you have chosen the path of the Sorcerer!");
                            Character sorcerer = new Sorcerer(name);
                            Thread.Sleep(1500);

                            characterInfo(sorcerer);
                            Console.WriteLine("\nPress any key to continue...\n");
                            Console.ReadKey();

                            return sorcerer;


                        case "3":
                            Console.WriteLine($"Oh... I see, you have chosen the path of the Archer!");
                            Character archer = new Archer(name);
                            Thread.Sleep(1500);

                            characterInfo(archer);
                            Console.WriteLine("\nPress any key to continue...\n");
                            Console.ReadKey();

                            return archer;


                        case "4":
                            Console.WriteLine($"Oh... I see, you have chosen the path of the Jarl!");
                            Character jarl = new Jarl(name);
                            Thread.Sleep(1500);

                            characterInfo(jarl);
                            Console.WriteLine("\nPress any key to continue...\n");
                            Console.ReadKey();

                            return jarl;


                        case "5":
                            Console.WriteLine($"Oh... I see, you have chosen the path of the Bard!");
                            Character bard = new Bard(name);
                            Thread.Sleep(1500);

                            characterInfo(bard);
                            Console.WriteLine("\nPress any key to continue...\n");
                            Console.ReadKey();

                            return bard;


                        case "6":
                            Console.WriteLine($"Oh... I see, you have chosen the path of the Monster!");
                            Character monster = new Monster(name);
                            Thread.Sleep(1500);

                            characterInfo(monster);
                            Console.WriteLine("\nPress any key to continue...\n");
                            Console.ReadKey();

                            return monster;


                        case "7":
                            Console.WriteLine($"Oh... I see, you have chosen the path of the Dwarf!");
                            Character dwarf = new Dwarf(name);
                            Thread.Sleep(1500);

                            characterInfo(dwarf);
                            Console.WriteLine("\nPress any key to continue...\n");
                            Console.ReadKey();

                            return dwarf;


                        default:
                            configErrorMessage("Invalid choice:", " Please try again.");
                            Console.Clear();
                            continue;
                    }
                    break;
                }
                catch (ArgumentException ex)
                {
                    configErrorMessage("Exception:", ex.Message);
                    Console.Clear();
                }
            }
            return null;
        }

        public static Character enemyCharacterChoosingProcess()
        {
            int enemyType = rand.Next(1, 8);
            string enemyName = Character.enemyNames[rand.Next(22)] + " - " + Character.titles[rand.Next(94)];    
            switch (enemyType)
            {
                case 1:
                    Console.WriteLine($"Your enemy is Witcher");
                    return new Witcher(enemyName);
                case 2:
                    Console.WriteLine($"Your enemy is Sorcerer");
                    return new Sorcerer(enemyName);
                case 3:
                    Console.WriteLine($"Your enemy is Archer");
                    return new Archer(enemyName);
                case 4:
                    Console.WriteLine($"Your enemy is Jarl");
                    return new Jarl(enemyName);
                case 5:
                    Console.WriteLine($"Your enemy is Bard");
                    return new Bard(enemyName);
                case 6:
                    Console.WriteLine($"Your enemy is Monster");
                    return new Monster(enemyName);
                case 7:
                    Console.WriteLine($"Your enemy is Dwarf");
                    return new Dwarf(enemyName);
                default:
                    throw new Exception("Invalid enemy type generated.");
            }
        }

    }
}