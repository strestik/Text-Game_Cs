using System;
using System.Collections.Generic;
using System.Text;

namespace Console__game
{
    internal class Character
    {
        public string Name { get; private set; }
        public bool IsAlive { get; private set; } = true;
        public int HP { get; private set; }
        public int Stamina { get; private set; }
        public int Mana { get; private set; }
        public int Defense { get; private set; }
        public double Skill { get; private set; } // AttackMultiplier
        public int Respect { get; private set; }
        public int Level { get; private set; } = 1;                                // new idea of leveling system
        public int Experience { get; private set; } = 0;                           // new idea of leveling system
        public int ExperienceToNextLevel { get; private set; } = 100;              // new idea of leveling system
        public Dictionary<string, EffectStatus> Effects { get; private set; }
        public Dictionary<string, EquipStatus> Equip { get; private set; }


        public sealed class EffectStatus
        {
            public bool Is { get; set; }
            public int Duration { get; set; }

            public EffectStatus(bool isActive = false, int duration = 0)
            {
                Is = isActive;
                Duration = duration;
            }
        }

        public sealed class EquipStatus
        {
            public bool Own { get; set; }
            public int Dmg { get; set; }
            public string ? Effect { get; set; }
            public EquipStatus(int dmg, string effect, bool own = false)
            {
                Own = own;
                Effect = effect;
                Dmg = dmg;
            }
        }

        //            //# AI Ideas
        //            //# "white honey": {"own": 1, "amount": 0, "duration": 0},  # cleanses all effects
        //            //# "thunderbolt": {"own": 1, "amount": 0.25, "duration": 4},  # skill multiplier
        //            //# "cat": {"own": 1, "amount": 0.15, "duration": 4},  # defense multiplier
        //            //# "swallow": {"own": 1, "amount": 0.25, "duration": 4},  # healing multiplier
        //            //# "white gull": {"own": 1, "amount": 0.25, "duration": 4},  # mana multiplier
        //            //# "black blood": {"own": 1, "amount": 0.25, "duration": 4},  # defense against monsters
        //                "healing potion": { "own": 3,"amount": 50},
        //                        "stamina potion": { "own": 3,"amount": 45},
        //                        "mana potion": { "own": 3,"amount": 35}, 
        //                        "vlaštovka": { "own": 1,"amount": 25, "duration" : 4}, //# duration healing
        //                        "hrom": { "own": 2,"amount": 1.5}, # dmg multiplier
        //                        "vlk": { "own": 2,"amount": 0.15}, # sklill multiplier
        //                        "medvěd": { "own": 2,"amount": 0.25}, //# defense multiplier
        //                        "blizzard": { "own": 1,"amount": 20, "duration" : 4}, //# stamina regen
        //                        }

        //            self.equip = {
        //            //# "iron claws": {"own":False,"dmg_mutipl": 0.25},  # [owned, dmg multiplier]
        //            //# "elven lute": {"own":False,"dmg_mutipl": 0.25},  
        //            //# "siderite sword": {"own":False,"dmg_mutipl": 0.25},
        //            //# "skellige axe": {"own":False,"dmg_mutipl": 0.25},
        //            //# "brokilon bow": {"own":False,"dmg_mutipl": 0.25},
        //            //# "dimeritium staff": {"own":False,"dmg_mutipl": 0.25},
        //            //# "mahakam hammer" : {"own":False,"dmg_multiplier": 0.35}
        //                "bomb": { "own":True,"dmg": 60, "effect": None},  //# [owned, base dmg]
        //                        "poison bomb": { "own":True,"dmg": 50, "effect": "poisoned"},  //# [owned, base dmg, effect]
        //                        "fire bomb": { "own":True,"dmg": 50, "effect": "burning"},  
        //                        "frost bomb": { "own":True,"dmg": 50, "effect": "frozen"}, 
        //                        }

        public Character(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            { 
                throw new ArgumentException("Parameter must not be null, empty or whitespace."); 
            }
            this.IsAlive = true;
            this.Name = name;
            this.HP = 100;
            this.Stamina = 100;
            this.Mana = 0;
            this.Defense = 50;
            this.Skill = 1.0;
            this.Respect = 15;  // starting respect  15 == standart ; 0 == absolute neutral ; 50 == respected ; 100 == legendary ; -50 == hated ; -100 ==  きっしょー
            this.Level = 1;
            this.Experience = 0;
            this.ExperienceToNextLevel = 100;
            this.Effects = new Dictionary<string, EffectStatus>(StringComparer.OrdinalIgnoreCase)
            {
                ["burning"] = new EffectStatus(false, 0),
                ["poisoned"] = new EffectStatus(false, 0),
                ["stunned"] = new EffectStatus(false, 0),
                ["frozen"] = new EffectStatus(false, 0),
                ["bleeding"] = new EffectStatus(false, 0),
                ["healing"] = new EffectStatus(false, 0),
                ["stamina regen"] = new EffectStatus(false, 0),
                ["shielding"] = new EffectStatus(false, 0),
                ["cleanse"] = new EffectStatus(false, 0)
            };
            this.Equip = new Dictionary<string, EquipStatus>(StringComparer.OrdinalIgnoreCase)
            {
                ["bomb"] = new EquipStatus(60, null, true),
                ["poison bomb"] = new EquipStatus(50, "poisoned", true),
                ["fire bomb"] = new EquipStatus(50, "burning", true),
                ["frost bomb"] = new EquipStatus(50, "frozen", true)
            };
        }



    }
}
