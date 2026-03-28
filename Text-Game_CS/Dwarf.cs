using System;
using System.Collections.Generic;
using System.Text;

namespace Text_Game_CS
{
    internal class Dwarf : Character
    {
        public Random rand = new Random();
        public List<string> Abilities { get; private set; } = new List<string> { "Iron hands", "Advenced smelting", "Iron constitution", "Nobody tosses a dwarf" };  // Placeholder for Dwarf abilities, can be expanded with effects and mechanics later
        public Dwarf(string name) : base(name)
        {
            this.HP = 160 * rand.Next(90, 115) / 100;
            this.Stamina = 120 * rand.Next(90, 115) / 100;
            this.Mana = 20 * rand.Next(90, 115) / 100;
            this.Defense = 60 * rand.Next(90, 115) / 100;
            this.Skill = 25 * rand.Next(90, 115) / 100;
        }
    }
}