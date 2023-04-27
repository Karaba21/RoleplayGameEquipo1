using System;
using System.Collections.Generic;

namespace Library
{
    public class Spellbook
    {
        public List<Spell> spells {get ; set ;}
        public int damage { get ; set ;}
        public void AddSpell(Spell spell)
        {
            this.spells.Add(spell);
        }
        public void RemoveSpell(Spell spell)
        {
            this.spells.Remove(spell);
        }
    }
}