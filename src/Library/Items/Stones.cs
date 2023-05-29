using System;
using System.Collections.Generic;

namespace Library
{
    public class Stones : IAttackItem, IDefenseItem
    {
        public string name {get ; set;}
        public double damage { get ; set ;}
        public double defense { get ; set ;}
        public Stones()
        {
            this.name="Stones";
            this.damage = 40;
            this.defense = 20;
        }
    }
}