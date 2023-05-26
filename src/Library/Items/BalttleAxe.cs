using System;
using System.Collections.Generic;

namespace Library
{
    public class BattleAxe : IAttackItem, IDefenseItem
    {
        public double damage { get ; set ;}
        public double defense {get ; set;}
        public BattleAxe(string name)
        {
            this.damage = 65;
            this.defense = 20;   
        }
    }
}