using System;
using System.Collections.Generic;

namespace Library
{
    public class Bomber : Enemies
    {
        // string name
        // double health
        // List<Items> items
        // double VP
        public override Bombs item1 { get ;}
        public override Shield item2 { get ;}
        public override Scythe item3 { get ;}

        // double totalDamage = 125 + 0 + 90
        // double totalDefense = 0 + 50 + 15
        public Bomber(string name)
        {
            // Cada vez que creo un Enano, creo Bombas, un Escudo y una Guadaña
            Bombs bombs = new Bombs();
            Shield shield = new Shield();
            Scythe scythe = new Scythe();

            // La vida del personaje va a comenzar en 1000
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
        // public void UseAllStrength(Heroes hero)
        // public void AddItem(Items item)
        // public void RemoveItem(Items item)
        public void UseBombs(Heroes hero) // item1
        {
            if (hero.totalDefense < this.item1.damage)
            {
                hero.health = hero.health + hero.totalDefense - this.item1.damage;
            }
        } 
        public void UseScythe(Heroes hero) // item3
        {
            if (hero.totalDefense < this.item3.damage)
            {
                hero.health = hero.health + hero.totalDefense - this.item3.damage;
            }
        }       
    }
}



        







    






