using System;
using System.Collections.Generic;

namespace Library
{
    public class Dwarf : ICharacter
    {
        public string name { get ; set ;}
        public double health { get ; set ;}
        public Crossbow crossbow { get ; set ;}
        public Daggers daggers { get ; set ;}
        public Scythe scythe { get ; set ;}
        public double totaldamage // = 240
        {
            get
            {
                return this.crossbow.damage + this.daggers.damage + this.scythe.damage;
            }
        }
        public double totaldefense // = 40
        {
            get
            {
                return this.crossbow.defense + this.daggers.defense + this.scythe.defense;
            }
        }
        public Dwarf(string name)
        {
            // Cada vez que creo un Enano, creo una Ballesta, unas Dagas y una Guadaña
            Crossbow crossbow = new Crossbow();
            Daggers daggers = new Daggers();
            Scythe scythe = new Scythe();

            // La vida del personaje va a comenzar en 1000
            this.name = name;
            this.health = 1000;
            this.crossbow = crossbow;
            this.daggers = daggers;
            this.scythe = scythe;
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
        public void UseDaggers(ICharacter character)
        {
            if (character != this)
            {
                if (character.totaldefense < this.daggers.damage)
                {
                    character.health = character.health + character.totaldefense - this.daggers.damage;
                }
            }
        }
        public void UseCrossbow(ICharacter character)
        {
            if (character != this)
            {
                if (character.totaldefense < this.crossbow.damage)
                {
                    character.health = character.health + character.totaldefense - this.crossbow.damage;
                }
            }
        }
        public void UseScythe(ICharacter character)
        {
            if (character != this)
            {
                if (character.totaldefense < this.scythe.damage)
                {
                    character.health = character.health + character.totaldefense - this.scythe.damage;
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
        public void ActivateDynamite()
        {
            this.crossbow.damage = this.crossbow.damage * 2;
            this.daggers.damage = this.daggers.damage * 2;
            this.scythe.damage = this.scythe.damage * 2;

            this.crossbow.defense = this.crossbow.defense * 0.5;
            this.daggers.defense = this.daggers.defense * 0.5;
            this.scythe.defense = this.scythe.defense * 0.5;
        }
        public void DeactivateDynamite()
        {
            this.crossbow.damage = this.crossbow.damage / 2;
            this.daggers.damage = this.daggers.damage / 2;
            this.scythe.damage = this.scythe.damage / 2;

            this.crossbow.defense = this.crossbow.defense / 0.5;
            this.daggers.defense = this.daggers.defense / 0.5;
            this.scythe.defense = this.scythe.defense / 0.5;
        }
    }
}