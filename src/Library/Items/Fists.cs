using System;
using System.Collections.Generic;

namespace Library
{
    public class Fists : IAttackItem, IDefenseItem
    {
        public string name {get ; set;}
        public double damage { get ; set ;}
        public double defense { get ; set ;}
        public Fists()
        {
            this.name = "Fist";
            this.damage = 60;
            this.defense = 35;
        }
    }
}