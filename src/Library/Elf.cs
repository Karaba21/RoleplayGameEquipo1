using System;
using System.Collections.Generic;

namespace Library
{
    public class Elf : Character
    {
        public FireBalls fireballs { get ; set ;}
        public WhirlWind whirlwind { get ; set ;}
        public Shield shield { get ; set ;}
        public override double totaldamage // = 175
        {
            get
            {
                return this.fireballs.damage + this.whirlwind.damage + this.shield.damage;
            }
        }
        public override double totaldefense // = 70
        {
            get
            {
                return this.fireballs.defense + this.whirlwind.defense + this.shield.defense;
            }
        }
        public Elf(string name)
        {
            // Cada vez que creo un Elfo, creo Bolas de Fuego, un Tornado y un Escudo
            FireBalls fireballs = new FireBalls();
            WhirlWind whirlwind = new WhirlWind();
            Shield shield = new Shield();

            // La vida del personaje va a comenzar en 1000
            this.name = name;
            this.health = 1000;
            this.fireballs = fireballs;
            this.whirlwind = whirlwind;
            this.shield = shield;
        }
        public void UseFireBalls(Character character)
        {
            if (character != this)
            {
                if (character.totaldefense < this.fireballs.damage)
                {
                    character.health = character.health + character.totaldefense - this.fireballs.damage;
                }
            }
        }
        public void UseWhirlWind(Character character)
        {
            if (character != this)
            {
                if (character.totaldefense < this.whirlwind.damage)
                {
                    character.health = character.health + character.totaldefense - this.whirlwind.damage;
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