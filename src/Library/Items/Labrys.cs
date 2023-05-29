using System;
using Library;

namespace Library
{
    public class Labrys : IAttackItem
    {
        public double damage { get ; set ;}
        public string name {get ; set;}
        public Labrys()
        {
            this.name="Labrys";
            this.damage = 95;
        }
    }
}