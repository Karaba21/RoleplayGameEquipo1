using System;
using System.Collections.Generic;

namespace Library
{
    public class DarkKnight : Enemies
    {
        // string name
        // double health
        // List<Items> items
        // double VP
        public override Sword item1 { get ;}
        public override Armor item2 { get ;}
        public override Flail item3 { get ;}
        // double totalDamage = 75 + 0 + 85
        // double totalDefense = 10 + 35 + 20
        public DarkKnight(string name)
        {
            // Cada vez que creo un Caballero Oscuro, creo una Espada, una Armadura y un Flail
            Sword sword = new Sword();
            Armor armor = new Armor();
            Flail flail = new Flail();

            // La vida del personaje va a comenzar en 1000
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
        // public void UseAllStrength(Heroes hero)
        // public void AddItem(Items item)
        // public void RemoveItem(Items item)
        public void UseSword(Heroes hero) // item1
        {
            if (hero.totalDefense < this.item1.damage)
            {
                hero.health = hero.health + hero.totalDefense - this.item1.damage;
            }
        }
        public void UseFlail(Heroes hero) // item3
        {
            if (hero.totalDefense < this.item3.damage)
            {
                hero.health = hero.health + hero.totalDefense - this.item3.damage;
            }
        }
    }
}