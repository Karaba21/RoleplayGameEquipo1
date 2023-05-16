using System;
using System.Collections.Generic;

namespace Library
{
    public class Elf : Character
    {
        // string name
        // double health
        // List<Items> items
        public override FireBalls item1 { get ;}
        public override WhirlWind item2 { get ;}
        public override Shield item3 { get ;}
        // double totaldamage // = 175
        // double totaldefense // = 70
        public Elf(string name)
        {
            // Cada vez que creo un Elfo, creo Bolas de Fuego, un Tornado y un Escudo
            FireBalls fireballs = new FireBalls();
            WhirlWind whirlwind = new WhirlWind();
            Shield shield = new Shield();

            // La vida del personaje va a comenzar en 1000
            this.name = name;
            this.health = 1000;
            this.item1 = fireballs;
            this.item2 = whirlwind;
            this.item3 = shield;

            this.items.Add(this.item1);
            this.items.Add(this.item2);
            this.items.Add(this.item3);
        }
        // public void Heal()
        // public void RestoreHealth()
        // public void UseAllStrength(Character character)
        public void UseFireBalls(Character character) // item1
        {
            if (character != this)
            {
                if (character.totaldefense < this.item1.damage)
                {
                    character.health = character.health + character.totaldefense - this.item1.damage;
                }
            }
        }
        public void UseWhirlWind(Character character) // item2
        {
            if (character != this)
            {
                if (character.totaldefense < this.item2.damage)
                {
                    character.health = character.health + character.totaldefense - this.item2.damage;
                }
            }
        }
        public void HealOther(Character character, double medicine)
        {
            if (character != this)
            {
                character.Heal(medicine);
                this.Heal(5);
            }
        }
    }
}