using System;
using System.Collections.Generic;

namespace Library
{
    public class Gorgon : Enemies
    {
        // string name
        // double health
        // List<IItems> items
        // double VP
        public override SnakeHair item1 { get ;}
        public override DeathStare item2 { get ;}
        public override TelepathicHissing item3 { get ;}
        // double totalDamage = 60 + 105 + 25
        // doubel totalDefense = 20 + 25 + 20
        public Gorgon(string name)
        {
            // Cada vez que creo una Gorgona, creo unas Serpientes de Pelo, una Mirada Petrificadora, y un Silbido
            SnakeHair snakeHair = new SnakeHair();
            DeathStare deathStare = new DeathStare();
            TelepathicHissing hissing = new TelepathicHissing();

            // La vida del personaje va a comenzar en 1000
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
        // public void UseAllStrength(Heroes hero)
        // public void AddItem(IItems item)
        // public void RemoveItem(IItems item)
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