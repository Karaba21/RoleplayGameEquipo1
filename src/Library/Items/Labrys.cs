using System;
using Library;

namespace Library
{
    public class Labrys : IAttackItem
    {
        public double damage {get; set;}
        public Labrys()
        {
            this.damage = 95;
        }
    }
}