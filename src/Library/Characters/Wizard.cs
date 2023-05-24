using System;
using System.Collections.Generic;

namespace Library
{
    public class Wizard : Heroes
    {
        // string name
        // double health
        // List<Items> items
        // double VP
        // double VPposEncounter
        public override SpellBook item1 { get ;}
        public override MagicClub item2 { get ;}
        public override MagicHat item3 { get ;}
        // double totalDamage = 90 + (#spells * 15) + spellsDamage
        // double totalDefense = 5 + 40 + (#spells * 5) + spellsDefense
        public Wizard(string name)
        {
            // Cada vez que creo un Mago, creo un Libro de Hechizos y un Bastón mágico
            SpellBook spellBook = new SpellBook();
            MagicClub magicClub = new MagicClub();
            MagicHat magicHat = new MagicHat();

            // La vida del personaje va a comenzar en 1000
            this.name = name;
            this.health = 1000;
            this.item1 = spellBook;
            this.item2 = magicClub;
            this.item3 = magicHat;
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

        public void UseSpell(Spell spell, Enemies enemy) // item1
        {
            if (this.item1.spells.Contains(spell))
            {
                if (enemy.totalDefense < (spell.damage + this.item1.damage))
                {
                    enemy.health = enemy.health + enemy.totalDefense - spell.damage - this.item1.spellsDamageBonus;
                }
            }
        }
        public void UseMagicClub(Enemies enemy) // item2
        {
            if (enemy.totalDefense < this.item2.damage)
            {
                enemy.health = enemy.health + enemy.totalDefense - this.item2.damage;
            }
        }
    }
}