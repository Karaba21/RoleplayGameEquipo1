using System;
using System.Collections.Generic;

namespace Library
{
    public class Golem : Enemies
    {
        public override Fists item1 {get;}
        public override Golemite item2 {get;}
        public override Stones item3 {get;}

        public Golem (string name)
        {
            Fists fists = new Fists();
            Golemite golemite = new Golemite();
            Stones stones = new Stones();

            this.name = name;
            this.health = 1000;
            this.item1 = fists;
            this.item2 = golemite;
            this.item3 = stones;
            this.VP = 50;

            this.items.Add(this.item1);
            this.items.Add(this.item2);
            this.items.Add(this.item3);
        }

        public void UseFists(Enemies enemy) //item1
        {
            if (enemy.totaldefense < this.item1.damage)
            {
                enemy.health = enemy.health + enemy.totaldefense - this.item1.damage;
            }
        }
        public void UseGolemite(Enemies enemy) //item2
        {
            if (enemy.totaldefense < this.item2.damage)
            {
                enemy.health = enemy.health + enemy.totaldefense - this.item2.damage;
            }
        }
        public void UseStones(Enemies enemy) //item3
        {
            if (enemy.totaldefense < this.item3.damage)
            {
                enemy.health = enemy.health + enemy.totaldefense - this.item3.damage;
            }
        }
    }
}