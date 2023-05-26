using System;
using System.Collections.Generic;

namespace Library
{
    public class Stones : IAttackItem, IDefenseItem
    {
        public double damage { get ; set ;}
        public double defense { get ; set ;}
        public Stones()
        {
            this.damage = 40;
            this.defense = 20;
        }
    }
}