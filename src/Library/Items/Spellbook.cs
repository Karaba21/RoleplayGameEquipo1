using System;
using System.Collections.Generic;

namespace Library
{
    public class SpellBook : IAttackItem, IDefenseItem
    {
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
                double spellBonus = 0;
                foreach (Spell spell in this.spells)
                {
                    totalSpellDamage = totalSpellDamage + spell.damage;
                    spellBonus = spellBonus + 15;
                }
                return totalSpellDamage + spellBonus;
            }
            set
            {}
        }
        public double defense
        {
            get
            {
                double totalSpellDefense = 0;
                double spellsBonus = 0;
                foreach (Spell spell in this.spells)
                {
                    totalSpellDefense = totalSpellDefense + spell.defense;
                    spellsBonus = spellsBonus + 5;
                }
                return totalSpellDefense + spellsBonus;
            }
            set
            {}
        }
        public SpellBook()
        {
            List<Spell> spells = new List<Spell>();
            
            this.spells = spells;
        }
        public Spell AddSpell(string spellName, double damage, double defemse)
        {
            Spell spell = new Spell(spellName, damage, defemse);
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