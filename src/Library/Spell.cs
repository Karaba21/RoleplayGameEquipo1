using System;
using System.Collections.Generic;

namespace Library
{
    public class Spell : IItems
    {
        public string name { get ; set ;}
        public double damage { get ; set ;}
        public double defense { get ; set ;}
        public Spell(string name, double damage, double defense)
        {
            this.name = name;
            this.damage = damage;
            this.defense = defense;
        }
    }
}