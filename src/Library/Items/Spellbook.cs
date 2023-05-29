using System;
using System.Collections.Generic;

namespace Library
{
    public class SpellBook : IAttackItem, IDefenseItem
    {
        public string name { get ; set ;}
        public List<Spell> spells { get ; set ;}
        public double spellsDamageBonus
        {
            get
            {
                double spellsDamageBonus = spells.Count * 15;
                return spellsDamageBonus;
            }
        }
        public double spellsDefenseBonus
        {
            get
            {
                double spellsDefenseBonus = spells.Count * 5;
                return spellsDefenseBonus;
            }
        }
        public double damage
        {
            get
            {
                double totalSpellDamage = 0;
                foreach (Spell spell in this.spells)
                {
                    totalSpellDamage = totalSpellDamage + spell.damage;
                }
                return totalSpellDamage + this.spellsDamageBonus;
            }
            set
            {}
        }
        public double defense
        {
            get
            {
                double totalSpellDefense = 0;
                foreach (Spell spell in this.spells)
                {
                    totalSpellDefense = totalSpellDefense + spell.defense;
                }
                return totalSpellDefense + this.spellsDefenseBonus;
            }
            set
            {}
        }
        public SpellBook()
        {            
            this.name = "Spell Book";
            this.spells = new List<Spell>();
        }
        public Spell AddSpell(string spellName, double damage, double defense)
        {
            Spell spell = new Spell(spellName, damage, defense);
            this.spells.Add(spell);
            return spell;
        }
        public void RemoveSpell(Spell spell)
        {
            if (this.spells.Contains(spell))
            {
                this.spells.Remove(spell);
            }
        }
    }
}