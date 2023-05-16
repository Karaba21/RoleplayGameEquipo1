using System;
using System.Collections.Generic;

namespace Library
{
    public class SpellBook : Items
    {
        public List<Spell> spells { get ; set ;}
        public double spellsdamagebonus
        {
            get
            {
                double spellsdamagebonus = spells.Count * 15;
                return spellsdamagebonus;
            }
        }
        public double spellsdefensebonus
        {
            get
            {
                double spellsdefensebonus = spells.Count * 5;
                return spellsdefensebonus;
            }
        }
        public override double damage
        {
            get
            {
                double totalspelldamage = 0;
                double spellbonus = 0;
                foreach (Spell spell in this.spells)
                {
                    totalspelldamage = totalspelldamage + spell.damage;
                    spellbonus = spellbonus + 15;
                }
                return totalspelldamage + spellbonus;
            }
        }
        public override double defense
        {
            get
            {
                double totalspelldefense = 0;
                double spellsbonus = 0;
                foreach (Spell spell in this.spells)
                {
                    totalspelldefense = totalspelldefense + spell.defense;
                    spellsbonus = spellsbonus + 5;
                }
                return totalspelldefense + spellsbonus;
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