using System;
using System.Collections.Generic;

namespace Library
{
    public class Knife : IAttackItem
    {
        public string name { get ; set ;}
        public double damage { get ; set ;}
        public Knife()
        {
            this.name = "Knife";
            this.damage = 70;
        }
    }
}