using System;
using System.Collections.Generic;

namespace Library
{
    public class Dwarf : Heroes
    {
        // string name
        // double health
        // List<Items> items
        // double VP
        // double VPposEncounter
        public override Crossbow item1 { get ;}
        public override Daggers item2 { get ;}
        public override Scythe item3 { get ;}
        // double totalDamage = 80 + 70 + 90
        // double totalDefense = 5 + 20 + 15
        public Dwarf(string name)
        {
            // Cada vez que creo un Enano, creo una Ballesta, unas Dagas y una Guadaña
            Crossbow crossbow = new Crossbow();
            Daggers daggers = new Daggers();
            Scythe scythe = new Scythe();

            // La vida del personaje va a comenzar en 1000
            this.name = name;
            this.health = 1000;
            this.item1 = crossbow;
            this.item2 = daggers;
            this.item3 = scythe;
            this.VP = 0;

            this.items.Add(this.item1);
            this.items.Add(this.item2);
            this.items.Add(this.item3);
        }
        // public void Heal()
        // public void RestoreHealth()
        // public void UseAllStrength(Enemies enemy)
        // public void AddItem(Items item)
        // public void RemoveItem(Items item)
        public void UseCrossbow(Enemies enemy) // item1
        {
            if (enemy.totalDefense < this.item1.damage)
            {
                enemy.health = enemy.health + enemy.totalDefense - this.item1.damage;
            }
        }
        public void UseDaggers(Enemies enemy) // item2
        {
            if (enemy.totalDefense < this.item2.damage)
            {
                enemy.health = enemy.health + enemy.totalDefense - this.item2.damage;
            }
        }
        public void UseScythe(Enemies enemy) // item3
        {
            if (enemy.totalDefense < this.item3.damage)
            {
                enemy.health = enemy.health + enemy.totalDefense - this.item3.damage;
            }
        }
        public void ActivateDynamite()
        {
            this.item1.damage = this.item1.damage * 2;
            this.item2.damage = this.item2.damage * 2;
            this.item3.damage = this.item3.damage * 2;

            this.item1.defense = this.item1.defense * 0.5;
            this.item2.defense = this.item2.defense * 0.5;
            this.item3.defense = this.item3.defense * 0.5;
        }
        public void DeactivateDynamite()
        {
            this.item1.damage = this.item1.damage / 2;
            this.item2.damage = this.item2.damage / 2;
            this.item3.damage = this.item3.damage / 2;

            this.item1.defense = this.item1.defense / 0.5;
            this.item2.defense = this.item2.defense / 0.5;
            this.item3.defense = this.item3.defense / 0.5;
        }
    }
}