using System;
using System.Text;
using System.Threading;
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
            this.reporter.ReportDuelSetUp(this.hero, this.enemy);
            while (this.hero.health > 0 && this.enemy.health > 0)
            {
                this.hero.UseAllStrength(this.enemy);
                this.reporter.ReportAttack(this.hero, this.enemy);
                Thread.Sleep(100);
                if (this.enemy.health > 0)
                {
                    this.enemy.UseAllStrength(this.hero);
                    this.reporter.ReportAttack(this.enemy, this.hero);
                    Thread.Sleep(300);
                }
            }
            if (this.hero.health > 0)
            {
                this.reporter.ReportDuelResult(this.hero, this.enemy);
                this.hero.RestoreHealth();
                return this.hero;
            }
            else
            {
                this.reporter.ReportDuelResult(this.enemy, this.hero);
                return this.enemy;
            }
        }
    }
}