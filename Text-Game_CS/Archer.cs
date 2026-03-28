using System;
using System.Collections.Generic;
using System.Text;

namespace Text_Game_CS
{
    internal class Archer : Character
    {
        public Random rand = new Random();
        public List<string> Spells { get; private set; } = new List<string> { "Arrow Shot", "Ice Arrow", "Poison Arrow" };  // Placeholder for Archer skills, can be expanded with effects and mechanics later
        public Archer(string name) : base(name)
        {
            // Additional initialization for Archer-specific attributes can be added here
            this.HP = 120 * rand.Next(90, 115) / 100;
            this.Stamina = 80 * rand.Next(90, 115) / 100;
            this.Mana = 150 * rand.Next(90, 115) / 100;
            this.Defense = 50 * rand.Next(90, 115) / 100;
            this.Skill = 1.8 * rand.Next(90, 115) / 100;
            this.ExperienceToNextLevel = 120; // Adjusted for Archer leveling
        }
    }
}