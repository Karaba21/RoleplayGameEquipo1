using Library;
using System;

namespace Library
{
    public class FireFists : IAttackItem , IDefenseItem
    {
        public string name {get ; set;}
        public double damage { get ; set ;}
        public double defense { get ; set ;}
        public FireBalls fireBalls {get; set;}
        public Fists fists {get; set;}
        public FireFists()
        {
            this.name="Fire Fists";
            this.damage= fireBalls.damage + fists.damage;
            this.defense= fireBalls.defense + fists.defense;
        }
    }
}