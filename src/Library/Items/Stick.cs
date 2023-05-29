using System;
using System.Collections.Generic;

namespace Library
{
    public class Stick : IAttackItem
    {
        public string name {get ; set;}
        public double damage { get ; set ;}
        public Stick()
        {
            this.name="Stick";
            this.damage = 55;
        }
    }
}