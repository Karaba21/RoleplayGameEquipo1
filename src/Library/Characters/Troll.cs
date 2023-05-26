using System;
using System.Collections.Generic;

namespace Library
{
    public class Troll : Enemies
    {
        // string name
        // double health
        // List<IItems> items
        // double VP
        public override Shell item1 { get ;}
        public override Stick item2 { get ;}

        public override Stick item3 { get ;}

        // double totalDamage = 0 + 55 + 55
        // double totalDefense = 60 + 0 + 0
    
        public Troll(string name)
        {
            Shell shell = new Shell();
            Stick stick = new Stick();
            Stick stick2 = new Stick();

            this.name = name;
            this.health = 1000;
            this.item1 = shell;
            this.item2 = stick;
            this.item3 = stick;
            this.VP = 5;

            this.items.Add(this.item1);
            this.items.Add(this.item2);
            this.items.Add(this.item3);

            //public void UseAllStrength(Heroes hero)
            //public void AddItem(IItems item)
            //public void RemoveItem(IItems item)
        }
        public void UseStick(Heroes hero) // item2 y item3
        {
            if (hero.totalDefense < this.item2.damage)
            {
                hero.health = hero.health + hero.totalDefense - this.item2.damage;
            }
        }
    }
}
