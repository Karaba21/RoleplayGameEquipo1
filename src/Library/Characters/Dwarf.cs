using System;
using System.Collections.Generic;

namespace Library
{
    public class Dwarf : Character
    {
        // string name
        // double health
        // List<Items> items
        public override Crossbow item1 { get ;}
        public override Daggers item2 { get ;}
        public override Scythe item3 { get ;}
        // double totaldamage // = 240
        // double totaldefense // = 40
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

            this.items.Add(this.item1);
            this.items.Add(this.item2);
            this.items.Add(this.item3);
        }
        // public void Heal()
        // public void RestoreHealth()
        // public void UseAllStrength(Character character)
        public void UseDaggers(Character character) // item2
        {
            if (character != this)
            {
                if (character.totaldefense < this.item2.damage)
                {
                    character.health = character.health + character.totaldefense - this.item2.damage;
                }
            }
        }
        public void UseCrossbow(Character character) // item1
        {
            if (character != this)
            {
                if (character.totaldefense < this.item1.damage)
                {
                    character.health = character.health + character.totaldefense - this.item1.damage;
                }
            }
        }
        public void UseScythe(Character character) // item3
        {
            if (character != this)
            {
                if (character.totaldefense < this.item3.damage)
                {
                    character.health = character.health + character.totaldefense - this.item3.damage;
                }
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