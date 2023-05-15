using System;
using System.Collections.Generic;

namespace Library
{
    public class Elf : ICharacter
    {
        public string name { get ; set ;}
        public double health { get ; set ;}
        public FireBalls fireballs { get ; set ;}
        public WhirlWind whirlwind { get ; set ;}
        public Shield shield { get ; set ;}
        public double totaldamage
        {
            get
            {
                return this.fireballs.damage + this.whirlwind.damage + this.shield.damage;
            }
        }
        public double totaldefense
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
        public void Heal(double medicine)
        {
            this.health = this.health + medicine;
            if (this.health > 1000)
            {
                this.health = 1000;
            }
        }
        public void RestoreHealth()
        {
            this.health = 1000;
        }
        public void UseFireBalls(ICharacter character)
        {
            if (character != this)
            {
                if (character.totaldefense < this.fireballs.damage)
                {
                    character.health = character.health + character.totaldefense - this.fireballs.damage;
                }
            }
        }
        public void UseWhirlWind(ICharacter character)
        {
            if (character != this)
            {
                if (character.totaldefense < this.whirlwind.damage)
                {
                    character.health = character.health + character.totaldefense - this.whirlwind.damage;
                }
            }
        }
        public void UseAllStrength(ICharacter character)
        {
            if (character != this)
            {
                if (character.totaldefense < this.totaldamage)
                {
                    character.health = character.health + character.totaldefense - this.totaldamage;
                }
            }
        }
        public void HealOther(ICharacter character, double medicine)
        {
            if (character != this)
            {
                character.Heal(medicine);
                this.Heal(5);
            }
        }
    }
}