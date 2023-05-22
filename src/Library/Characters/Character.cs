using System;
using System.Collections.Generic;

namespace Library
{
    public abstract class Character
    {
        public string name { get ; set ;}
        public double health { get ; set ;}
        public List<Items> items = new List<Items>();
        public abstract Items item1 { get ;}
        public abstract Items item2 { get ;}
        public abstract Items item3 { get ;}
        public double VP { get ; set ;}
        public double totalDamage
        {
            get
            {
                double totalDamage = 0;
                foreach (Items item in this.items)
                {
                    totalDamage = totalDamage + item.damage;
                }
                return totalDamage;
            }
        }
        public double totalDefense
        {
            get
            {
                double totalDefense = 0;
                foreach (Items item in this.items)
                {
                    totalDefense = totalDefense + item.defense;
                }
                return totalDefense;
            }
        }
        public void AddItem(Items item)
        {
            this.items.Add(item);
        }
        public void RemoveItem(Items item)
        {
            if (this.items.Contains(item) && item != this.item1 && item != this.item2 && item != this.item3)
            {
                this.items.Remove(item);
            }
        }
    }
}