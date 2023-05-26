using System;
using System.Collections.Generic;

namespace Library
{
    public class Elf : Heroes
    {
        // string name
        // double health
        // List<IItems> items
        // double VP
        // double VPposEncounter
        public override FireBalls item1 { get ;}
        public override WhirlWind item2 { get ;}
        public override Shield item3 { get ;}
        // double totalDamage = 85 + 90 + 0
        // double totalDefense = 5 + 0 + 50
        public Elf(string name)
        {
            // Cada vez que creo un Elfo, creo unas Bolas de Fuego, un Tornado y un Escudo
            FireBalls fireBalls = new FireBalls();
            WhirlWind whirlWind = new WhirlWind();
            Shield shield = new Shield();

            // La vida del personaje va a comenzar en 1000
            this.name = name;
            this.health = 1000;
            this.item1 = fireBalls;
            this.item2 = whirlWind;
            this.item3 = shield;
            this.VP = 0;

            this.items.Add(this.item1);
            this.items.Add(this.item2);
            this.items.Add(this.item3);
        }
        // public void Heal()
        // public void RestoreHealth()
        // public void UseAllStrength(Enemies enemy)
        // public void AddItem(IItems item)
        // public void RemoveItem(IItems item)
        public void UseFireBalls(Enemies enemy) // item1
        {
            if (enemy.totalDefense < this.item1.damage)
            {
                enemy.health = enemy.health + enemy.totalDefense - this.item1.damage;
            }
        }
        public void UseWhirlWind(Enemies enemy) // item2
        {
            if (enemy.totalDefense < this.item2.damage)
            {
                enemy.health = enemy.health + enemy.totalDefense - this.item2.damage;
            }
        }
        public void HealOther(Heroes hero, double medicine)
        {
            if (hero != this)
            {
                hero.Heal(medicine);
                this.Heal(5);
            }
        }
    }
}