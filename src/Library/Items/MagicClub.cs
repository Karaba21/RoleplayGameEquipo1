using System;
using System.Collections.Generic;

namespace Library
{
    public class MagicClub : IAttackItem, IDefenseItem
    {
        public double damage { get ; set ;}
        public double defense { get ; set ;}
        public MagicClub()
        {
            this.damage = 90;
            this.defense = 5;
        }
    }
}