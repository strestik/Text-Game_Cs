using System;
using System.Collections.Generic;
using System.Text;

namespace Text_Game_CS
{
    internal class Bard : Character
    {
        public Random rand = new Random();
        public List<string> Songs { get; private set; } = new List<string> { "Song of Valor", "Melody of Healing", "Ballad of Strength", "Harmony of Protection", "Lullaby of Sleep" };  // Placeholder for Bard songs, can be expanded with effects and mechanics later
        public Bard(string name) : base(name)
        {
            // Additional initialization for Bard-specific attributes can be added here
            this.HP = 110 * rand.Next(90, 115) / 100;
            this.Stamina = 90 * rand.Next(90, 115) / 100;
            this.Mana = 120 * rand.Next(90, 115) / 100;
            this.Defense = 60 * rand.Next(90, 115) / 100;
            this.Skill = 1.6 * rand.Next(90, 115) / 100;
            this.ExperienceToNextLevel = 110; // Adjusted for Bard leveling
        }
    }
}
