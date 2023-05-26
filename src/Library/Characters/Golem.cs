using System;
using System.Collections.Generic;

namespace Library
{
    public class Golem : Enemies
    {
        // string name
        // double health
        // List<IItems> items
        // double VP
        public override Fists item1 { get ;}
        public override Golemite item2 { get ;}
        public override Stones item3 { get ;}
        // double totalDamage = 60 + 60 + 40
        // double totalDefense = 35 + 5 + 20
        public Golem(string name)
        {
            // Cada vez que creo un Golem, creo unos Puños, una Golemita, y unas Piedras
            Fists fists = new Fists();
            Golemite golemite = new Golemite();
            Stones stones = new Stones();

            // La vida del personaje va a comenzar en 1000
            this.name = name;
            this.health = 1000;
            this.item1 = fists;
            this.item2 = golemite;
            this.item3 = stones;
            this.VP = 3;

            this.items.Add(this.item1);
            this.items.Add(this.item2);
            this.items.Add(this.item3);
        }
        // public void UseAllStrength(Heroes hero)
        // public void AddItem(IItems item)
        // public void RemoveItem(IItems item)
        public void UseFists(Heroes hero) // item1
        {
            if (hero.totalDefense < this.item1.damage)
            {
                hero.health = hero.health + hero.totalDefense - this.item1.damage;
            }
        }
        public void UseGolemite(Heroes hero) // item2
        {
            if (hero.totalDefense < this.item2.damage)
            {
                hero.health = hero.health + hero.totalDefense - this.item2.damage;
            }
        }
        public void UseStones(Heroes hero) // item3
        {
            if (hero.totalDefense < this.item3.damage)
            {
                hero.health = hero.health + hero.totalDefense - this.item3.damage;
            }
        }
    }
}