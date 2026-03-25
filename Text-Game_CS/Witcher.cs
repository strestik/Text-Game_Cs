using System;
using System.Collections.Generic;
using System.Text;

namespace Text_Game_CS
{
    internal class Witcher : Character
    {
        public static Random rand = new Random();
        public List<string> Signs { get; private set; } = new List<string> { "Aard", "Igni", "Yrden", "Quen", "Axii" };  // Placeholder for Witcher signs, can be expanded with effects and mechanics later
        public Witcher(string name) : base(name)
        {
            // Additional initialization for Witcher-specific attributes can be added here
            this.HP = 160 * rand.Next(90, 115) / 100;
            this.Stamina = 120 * rand.Next(90, 115) / 100;
            this.Mana = 60 * rand.Next(90, 115) / 100;
            this.Defense = 70 * rand.Next(90, 115) / 100;
            this.Skill = 1.5 * rand.Next(90, 115) / 100;
            this.ExperienceToNextLevel = 150; // Adjusted for Witcher leveling
            //this.ASCII = 
        }
    }
}
