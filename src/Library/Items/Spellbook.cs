using System;
using System.Collections.Generic;

namespace Library
{
    public class SpellBook : Items
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
        public override double damage
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
        }
        public override double defense
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
        }
        public SpellBook()
        {
            List<Spell> spells = new List<Spell>();
            
            this.spells = spells;
        }
        public void AddSpell(Spell spell)
        {
            this.spells.Add(spell);
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