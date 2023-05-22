using System;
using System.Collections.Generic;

namespace Library
{
    public class Bomber : Enemies
    {
        public override Bombs item1 { get ;}
        public override Shield item2 { get ;}
        public override Scythe item3 { get ;}
        public Bomber(string name)
        {
            Bombs bombs = new Bombs();
            Shield shield = new Shield();
            Scythe scythe = new Scythe();

            this.name = name;
            this.health = 1000;
            this.item1 = bombs;
            this.item2 = shield;
            this.item3 = scythe;
            this.VP = 5;

            this.items.Add(this.item1);
            this.items.Add(this.item2);
            this.items.Add(this.item3);
        }
        public void UseScythe(Heroes hero) // item3
        {
            if (hero.totalDefense < this.item3.damage)
            {
                hero.health = hero.health + hero.totalDefense - this.item3.damage;
            }
        }
        public void UseBombs(Heroes hero) // item1
        {
            if (hero.totalDefense < this.item1.damage)
            {
                hero.health = hero.health + hero.totalDefense - this.item1.damage;
            }
        }        
    }
}



        







    






