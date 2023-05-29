using System;
using System.Collections.Generic;

namespace Library
{
    public class Golemite : IAttackItem, IDefenseItem
    {
        public string name {get ; set;}
        public double damage { get ; set ;}
        public double defense { get ; set ;}
        public Golemite()
        {
            this.name="Golemite";
            this.damage = 60;
            this.defense = 5;
        }
    }
}