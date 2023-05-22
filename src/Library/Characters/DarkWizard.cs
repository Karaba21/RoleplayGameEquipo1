using System;
using System.Collections.Generic;

namespace Library
{
    public class DarkWizard : Enemies
    {
        public override Daggers item1{ get ;}
        public override FireBalls item2 { get ;}
        public override Scythe item3 { get ;}
        public DarkWizard(string name)
        {
            Daggers daggers = new Daggers();
            FireBalls fireBalls = new FireBalls();
            Scythe scythe = new Scythe();

            this.name = name;
            this.health = 1000;
            this.item1 = daggers;
            this.item2 = fireBalls;
            this.item3 = scythe;
            this.VP = 4;
            
            this.items.Add(this.item1);
            this.items.Add(this.item2);
            this.items.Add(this.item3); 
        }
        public void UseDaggers(Heroes hero) // item1
        {
            if (hero.totalDefense < this.item1.damage)
            {
                hero.health = hero.health + hero.totalDefense - this.item1.damage;
            }
        }
        public void UseFireBalls(Heroes hero) // item2
        {
            if (hero.totalDefense < this.item2.damage)
            {
                hero.health = hero.health + hero.totalDefense - this.item2.damage;
            }
        }
        public void UseScythe(Heroes hero) // item3
        {
            if (hero.totalDefense < this.item3.damage)
            {
                hero.health = hero.health + hero.totalDefense - this.item3.damage;
            }
        }
    }
}