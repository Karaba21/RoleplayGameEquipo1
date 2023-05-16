using System;
using System.Collections.Generic;

namespace Library
{
    public class Wizard : Character
    {
        // string name
        // double health
        // List<Items> items
        public override SpellBook item1 { get ;}
        public override MagicClub item2 { get ;}
        public override MagicHat item3 { get ;}
        // double totaldamage = 90 + (#spells * 15) + spellsdamage
        // double totaldefense = 5 + (#spells * 5) + spellsdefense
        public Wizard(string name)
        {
            // Cada vez que creo un Mago, creo un Libro de Hechizos y un Bastón mágico
            SpellBook spellbook = new SpellBook();
            MagicClub magicclub = new MagicClub();
            MagicHat magichat = new MagicHat();

            // La vida del personaje va a comenzar en 1000
            this.name = name;
            this.health = 1000;
            this.item1 = spellbook;
            this.item2 = magicclub;
            this.item3 = magichat;

            this.items.Add(this.item1);
            this.items.Add(this.item2);
            this.items.Add(this.item3);
        }
        // public void Heal()
        // public void RestoreHealth()
        // public void UseAllStrength(Character character)
        public void UseMagicClub(Character character) // item2
        {
            if (character != this)
            {
                if (character.totaldefense < this.item2.damage)
                {
                    character.health = character.health + character.totaldefense - this.item2.damage;
                }
            }
        }
        public void UseSpell(Spell spell, Character character) // item1
        {
            if (character != this)
            {
                if (this.item1.spells.Contains(spell))
                {
                    if (character.totaldefense < (spell.damage + this.item1.damage))
                    {
                        character.health = character.health + character.totaldefense - spell.damage - this.item1.spellsdamagebonus;
                    }
                }
            }
        }
    }
}