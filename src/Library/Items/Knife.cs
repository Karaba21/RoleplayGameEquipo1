using System;
using System.Collections.Generic;

namespace Library
{
    public class Knife : IAttackItem
    {
        public double damage { get ; set ;}
        public Knife()
        {
            this.damage = 70;
        }
    }
}