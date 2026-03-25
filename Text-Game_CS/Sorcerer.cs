using System;
using System.Collections.Generic;
using System.Text;

namespace Text_Game_CS
{
    internal class Sorcerer : Character
    {
        public static Random rand = new Random();
        public List<string> Spells { get; private set; } = new List<string> { "Fireball", "Ice Shard", "Lightning Bolt", "Heal", "Shield" };  // Placeholder for Sorcerer spells, can be expanded with effects and mechanics later
        public Sorcerer(string name) : base(name)
        {
            // Additional initialization for Sorcerer-specific attributes can be added here
            this.HP = 120 * rand.Next(90, 115) / 100;
            this.Stamina = 80 * rand.Next(90, 115) / 100;
            this.Mana = 150 * rand.Next(90, 115) / 100;
            this.Defense = 50 * rand.Next(90, 115) / 100;
            this.Skill = 1.8 * rand.Next(90, 115) / 100;
            this.ExperienceToNextLevel = 120; // Adjusted for Sorcerer leveling
        }
    }
}