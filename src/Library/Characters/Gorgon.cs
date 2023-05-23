using System;
using System.Collections.Generic;

namespace Library
{
    public class Gorgon : Enemies
    {
        public override SnakeHair item1 { get ;}
        public override DeathStare item2 { get ;}
        public override TelepathicHissing item3 { get ;}
        public Gorgon(string name)
        {
            SnakeHair snakeHair = new SnakeHair();
            DeathStare deathStare = new DeathStare();
            TelepathicHissing hissing = new TelepathicHissing();

            this.name = name;
            this.health = 1000;
            this.item1 = snakeHair;
            this.item2 = deathStare;
            this.item3 = hissing;
            this.VP = 4;

            this.items.Add(this.item1);
            this.items.Add(this.item2);
            this.items.Add(this.item3);
        }
        public void UseSnakeHair(Heroes hero) // item1
        {
            if (hero.totalDefense < this.item1.damage)
            {
                hero.health = hero.health + hero.totalDefense - this.item1.damage;
            }
        }
        public void UseDeathStare(Heroes hero) // item2
        {
            if (hero.totalDefense < this.item2.damage)
            {
                hero.health = hero.health + hero.totalDefense - this.item2.damage;
            }
        }
        public void UseTelepathicHissing(Heroes hero) // item3
        {
            if (hero.totalDefense < this.item3.damage)
            {
                hero.health = hero.health + hero.totalDefense - this.item3.damage;
            }
        }
    }
}