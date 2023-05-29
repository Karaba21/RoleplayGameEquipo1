using System;
using System.Text;
using System.Collections.Generic;

namespace Library
{
    public class Duel : Encounter
    {
        public Heroes hero { get ; set ;}
        public Enemies enemy { get ; set ;}
        public Duel(Heroes hero, Enemies enemy)
        {
            this.reporter = new ConsoleReporter();
            this.hero = hero;
            this.enemy = enemy;
        }
        public Character DoEncounter()
        {
            while (this.hero.health > 0 && this.enemy.health > 0)
            {
                this.hero.UseAllStrength(this.enemy);
                this.reporter.ReportAttack(this.hero, this.enemy);
                this.enemy.UseAllStrength(this.hero);
                this.reporter.ReportAttack(this.enemy, this.hero);
            }
            if (this.hero.health > 0)
            {
                this.reporter.ReportDuel(this.hero, this.enemy);
                this.hero.RestoreHealth();
                return this.hero;
            }
            else
            {
                this.reporter.ReportDuel(this.enemy, this.hero);
                return this.enemy;
            }
        }
    }
}