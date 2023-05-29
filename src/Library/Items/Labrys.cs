using System;
using Library;

namespace Library
{
    public class Labrys : IAttackItem
    {
        public string name { get ; set ;}
        public double damage { get ; set ;}
        public Labrys()
        {
            this.name = "Labrys";
            this.damage = 95;
        }
    }
}