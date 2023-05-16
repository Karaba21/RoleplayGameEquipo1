using System;
using System.Collections.Generic;

namespace Library
{
    public class Wizard : Character
    {
        public SpellBook spellbook { get ; set ;} // podria llamarlos elemento 1 2 3 y generalizar el metodo
        public MagicClub magicclub { get ; set ;}
        public override double totaldamage // = 90 + (#spells * 15) + spellsdamage
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
        public override double totaldefense // = 5 + (#spells * 5) + spellsdefense
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
        public void UseMagicClub(Character character)
        {
            if (character != this)
            {
                if (character.totaldefense < this.magicclub.damage)
                {
                    character.health = character.health + character.totaldefense - this.magicclub.damage;
                }
            }
        }
        public void UseSpell(Spell spell, Character character)
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
    }
}