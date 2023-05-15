using System;
using System.Collections.Generic;

namespace Library
{
    public class SpellBook : IItems
    {
        public List<Spell> spells {get ; set ;}
        public double damage { get ; set ;}
        public double defense { get ; set ;}
        public SpellBook()
        {
            List<Spell> spells = new List<Spell>();
            
            this.damage = 0;
            this.defense = 0;
            this.spells = spells;
        }
        public void AddSpell(Spell spell)
        {
            this.spells.Add(spell);
            this.damage = this.damage + 15;
            this.defense = this.defense + 5;
        }
        public void RemoveSpell(Spell spell)
        {
            if (this.spells.Contains(spell))
            {
                this.spells.Remove(spell);
                this.damage = this.damage - 15;
                this.defense = this.defense - 5;
            }
        }
    }
}