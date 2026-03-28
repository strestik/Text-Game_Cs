using System;
using System.Collections.Generic;
using System.Text;

namespace Text_Game_CS
{
    internal class Jarl : Character
    {
        public Random rand = new Random();
        public List<string> Spells { get; private set; } = new List<string> { "Summon Guard", "Royal Decree", "Shield Bash" };  // Placeholder for Jarl skills, can be expanded with effects and mechanics later
        public Jarl(string name) : base(name)
        {
            // Additional initialization for Jarl-specific attributes can be added here
            this.HP = 120 * rand.Next(90, 115) / 100;
            this.Stamina = 80 * rand.Next(90, 115) / 100;
            this.Mana = 150 * rand.Next(90, 115) / 100;
            this.Defense = 50 * rand.Next(90, 115) / 100;
            this.Skill = 1.8 * rand.Next(90, 115) / 100;
            this.ExperienceToNextLevel = 120; // Adjusted for Jarl leveling
        }
    }
}