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
        public double totaldamage
        {
            get
            {
                double totaldamage = 0;
                foreach (Items item in this.items)
                {
                    totaldamage = totaldamage + item.damage;
                }
                return totaldamage;
            }
        }
        public double totaldefense
        {
            get
            {
                double totaldefense = 0;
                foreach (Items item in this.items)
                {
                    totaldefense = totaldefense + item.defense;
                }
                return totaldefense;
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