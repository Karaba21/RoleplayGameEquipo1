using System;
using System.Collections.Generic;

namespace Library
{
    public class Bombs : IAttackItem
    {
        public double damage { get ; set ;}
        public Bombs()
        {
            this.damage = 125;
        }
    }
}