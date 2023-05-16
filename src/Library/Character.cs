using System;
using System.Collections.Generic;

namespace Library
{
    public abstract class Character
    {
        public string name { get ; set ;}
        public double health { get ; set ;}
        public abstract double totaldamage { get ;}
        public abstract double totaldefense { get ;}
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
        public void UseAllStrength(Character character)
        {
            if (character != this)
            {
                if (character.totaldefense < this.totaldamage)
                {
                    character.health = character.health + character.totaldefense - this.totaldamage;
                }
            }
        }
    }
}