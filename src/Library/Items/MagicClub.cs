using System;
using System.Collections.Generic;

namespace Library
{
    public class MagicClub : IAttackItem, IDefenseItem
    {
        public string name {get ; set;}
        public double damage { get ; set ;}
        public double defense { get ; set ;}
        public MagicClub()
        {
            this.name="Magic club";
            this.damage = 90;
            this.defense = 5;
        }
    }
}