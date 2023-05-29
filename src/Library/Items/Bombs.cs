using System;
using System.Collections.Generic;

namespace Library
{
    public class Bombs : IAttackItem
    {
        public string name { get ; set ;}
        public double damage { get ; set ;}
        public Bombs()
        {
            this.name = "Bombs";
            this.damage = 125;
        }
    }
}