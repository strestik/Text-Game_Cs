using System;
using System.Collections.Generic;
using System.Text;

namespace Text_Game_CS
{
    internal class Monster : Character
    {
        public Random rand = new Random();
        public List<string> Abilities { get; private set; } = new List<string> { "Claw Swipe", "Roar", "Tail Whip" };  // Placeholder for Monster abilities, can be expanded with effects and mechanics later
        public Monster(string name) : base(name)
        {
            // Additional initialization for Monster-specific attributes can be added here
            this.HP = 200 * rand.Next(90, 115) / 100;
            this.Stamina = 150 * rand.Next(90, 115) / 100;
            this.Mana = 30 * rand.Next(90, 115) / 100;
            this.Defense = 80 * rand.Next(90, 115) / 100;
            this.Skill = 1.2 * rand.Next(90, 115) / 100;
            this.ExperienceToNextLevel = 200; // Adjusted for Monster leveling
        }
    }
}