using System;
using System.Collections.Generic;

namespace Library
{
    public class Crossbow : IItems
    {
        public double damage { get ; set ;}
        public double defense { get ; set ;}
        public Crossbow()
        {
            this.damage = 80;
            this.defense = 5;
        }
    }
}