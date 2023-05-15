using System;
using System.Collections.Generic;

namespace Library
{
    public class Wizard : ICharacter
    {
        public string name { get ; set ;}
        public double health { get ; set ;}
        public SpellBook spellbook { get ; set ;}
        public MagicClub magicclub { get ; set ;}
        public double totaldamage
        {
            get
            {
                double spelldamage = 0;
                foreach (Spell spell in this.spellbook.spells)
                {
                    spelldamage = spelldamage + spell.damage;
                }
                double totaldamage = this.magicclub.damage + this.spellbook.damage + spelldamage;

                return totaldamage;
            }
        }
        public double totaldefense
        {
            get
            {
            double spelldefense = 0;
            foreach (Spell spell in this.spellbook.spells)
            {
                spelldefense = spelldefense + spell.defense;
            }
            double totaldefense = this.magicclub.defense + this.spellbook.defense + spelldefense;

            return totaldefense; 
            }
        }
        public Wizard(string name)
        {
            // Cada vez que creo un Mago, creo un Libro de Hechizos y un Bastón mágico
            SpellBook spellbook = new SpellBook();
            MagicClub magicclub = new MagicClub();

            // La vida del personaje va a comenzar en 1000
            this.name = name;
            this.health = 1000;
            this.spellbook = spellbook;
            this.magicclub = magicclub;
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
        public void UseMagicClub(ICharacter character)
        {
            if (character != this)
            {
                if (character.totaldefense < this.magicclub.damage)
                {
                    character.health = character.health + character.totaldefense - this.magicclub.damage;
                }
            }
        }
        public void UseSpell(Spell spell, ICharacter character)
        {
            if (character != this)
            {
                if (this.spellbook.spells.Contains(spell))
                {
                    if (character.totaldefense < (spell.damage + this.spellbook.damage))
                    {
                    character.health = character.health + character.totaldefense - spell.damage - this.spellbook.damage;
                    }
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
    }
}