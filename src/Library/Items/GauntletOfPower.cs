using System;
using System.Collections.Generic;

namespace Library
{
    public class GauntletOfPower : IAttackItem, IDefenseItem
    {
        public List<Gem> gems { get ; set ;}
        public double damage
        {
            get
            {
                double gemsDamage = 0;
                foreach (Gem gem in this.gems)
                {
                    gemsDamage = gemsDamage + 40;
                }
                return gemsDamage;
            }
            set
            {}
        }
        public double defense
        {
            get
            {
                double gemsDefense = 0;
                foreach (Gem gem in this.gems)
                {
                    gemsDefense = gemsDefense + 10;
                }
                return gemsDefense;
            }
            set
            {}
        }
        public GauntletOfPower()
        {
            this.gems = new List<Gem>();
        }
        public Gem AddGem(double damage, double defense)
        {
            Gem gem = new Gem();
            this.gems.Add(gem);
            return gem;
        }
        public void RemoveGem(Gem gem)
        {
            this.gems.Remove(gem);
        }
    }
}