using System;
using System.Collections.Generic;

namespace Library
{
    public class Fists : IAttackItem, IDefenseItem
    {
        public double damage { get ; set ;}
        public double defense { get ; set ;}
        public Fists()
        {
            this.damage = 60;
            this.defense = 35;
        }
    }
}