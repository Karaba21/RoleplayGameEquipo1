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
        public void UseSword(Enemies enemy) // item1
        {
            if (enemy.totaldefense < this.item1.damage)
            {
                enemy.health = enemy.health + enemy.totaldefense - this.item1.damage;
            }
        }
        public void UseArmor(Enemies enemy) // item2
        {
            if (enemy.totaldefense < this.item2.damage)
            {
                enemy.health = enemy.health + enemy.totaldefense - this.item2.damage;
            }
        }
        public void UseFlail(Enemies enemy) // item3
        {
            if (enemy.totaldefense < this.item3.damage)
            {
                enemy.health = enemy.health + enemy.totaldefense - this.item3.damage;
            }
        }
    }
}