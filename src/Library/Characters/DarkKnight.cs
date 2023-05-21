using System;
using System.Collections.Generic;

namespace Library
{
    public class DarkKnight : Enemies
    {
        public override Sword item1 { get ;}
        public override Armor item2 { get ;}
        public override Flail item3 { get ;}
        public DarkKnight(string name)
        {
            Sword sword = new Sword();
            Armor armor = new Armor();
            Flail flail = new Flail();

            this.name = name;
            this.health = 1000;
            this.item1 = sword;
            this.item2 = armor;
            this.item3 = flail;
            this.VP = 5;

            this.items.Add(this.item1);
            this.items.Add(this.item2);
            this.items.Add(this.item3);
        }
        public void UseSword(Heroes hero) // item1
        {
            if (hero.totaldefense < this.item1.damage)
            {
                hero.health = hero.health + hero.totaldefense - this.item1.damage;
            }
        }
        public void UseArmor(Heroes hero) // item2
        {
            if (hero.totaldefense < this.item2.damage)
            {
                hero.health = hero.health + hero.totaldefense - this.item2.damage;
            }
        }
        public void UseFlail(Heroes hero) // item3
        {
            if (hero.totaldefense < this.item3.damage)
            {
                hero.health = hero.health + hero.totaldefense - this.item3.damage;
            }
        }
    }
}