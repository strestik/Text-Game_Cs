using System;
using System.Collections.Generic;
using System.Text;

namespace Text_Game_CS
{
    internal class Dwarf : Character
    {
        public static Random rand = new Random();
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