using System;
using System.Collections.Generic;

namespace Library
{
    public class Crossbow : IAttackItem, IDefenseItem
    {
        public string name { get ; set ;}
        public double damage { get ; set ;}
        public double defense { get ; set ;}
        public Crossbow()
        {
            this.name = "Crossbow";
            this.damage = 80;
            this.defense = 5;
        }
    }
}