using System;
using System.Collections.Generic;

namespace Library
{
    public class BattleAxe : IAttackItem, IDefenseItem
    {
        public string name { get ; set ;}
        public double damage { get ; set ;}
        public double defense {get ; set;}
        public BattleAxe(string name)
        {
            this.name = "Battle Axe";
            this.damage = 65;
            this.defense = 20;   
        }
    }
}