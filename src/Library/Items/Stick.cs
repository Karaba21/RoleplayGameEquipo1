using System;
using System.Collections.Generic;

namespace Library
{
    public class Stick : IAttackItem
    {
        public double damage { get ; set ;}
        public Stick()
        {
            this.damage = 55;
        }
    }
}