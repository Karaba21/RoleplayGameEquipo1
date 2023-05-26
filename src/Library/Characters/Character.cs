using System;
using System.Collections.Generic;

namespace Library
{
    public abstract class Character
    {
        public string name { get ; set ;}
        public double health { get ; set ;}
        public List<IItems> items = new List<IItems>();
        public abstract IItems item1 { get ;}
        public abstract IItems item2 { get ;}
        public abstract IItems item3 { get ;}
        public double VP { get ; set ;}
        public double totalDamage
        {
            get
            {
                double totalDamage = 0;
                foreach (IItems item in this.items)
                {
                    if (item is IAttackItem)
                    {
                        totalDamage = totalDamage + ((IAttackItem) item).damage;
                    }
                }
                return totalDamage;
            }
        }
        public double totalDefense
        {
            get
            {
                double totalDefense = 0;
                foreach (IItems item in this.items)
                {
                    if (item is IDefenseItem)
                    {
                        totalDefense = totalDefense + ((IDefenseItem) item).defense;
                    }
                }
                return totalDefense;
            }
        }
        public void AddItem(IItems item)
        {
            this.items.Add(item);
        }
        public void RemoveItem(IItems item)
        {
            if (item != this.item1 && item != this.item2 && item != this.item3)
            {
                this.items.Remove(item);
            }
        }
    }
}