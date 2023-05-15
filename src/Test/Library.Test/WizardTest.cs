using System;
using Library;
using System.Collections.Generic;
using NUnit.Framework;

namespace Library.Test
{
    public class WizardTest
    // En esta clase hay 8 tests.
    {
        private Wizard mywizard;
        private Wizard otherwizard;
        private Dwarf dwarf;
        private Spell spell1;
        private Spell spell2;
        private Spell spell3;
        [SetUp]
        public void SetUp()
        {
            mywizard = new Wizard("Merlin");
            otherwizard = new Wizard("Houdini");
            dwarf = new Dwarf("Grumpy");
            spell1 = new Spell("ataque", 50, 0);
            spell2 = new Spell("golpe", 20, 0);
            spell3 = new Spell("escudo", 0, 30);

            mywizard.spellbook.AddSpell(spell1);
            mywizard.spellbook.AddSpell(spell2);
            mywizard.spellbook.AddSpell(spell3);
        }
        [Test]
        public void GetTotalDefenseTest()
        {
            double expected = 50;

            Assert.That(expected, Is.EqualTo(mywizard.totaldefense));
        }
        [Test]
        public void UseSpellTest1()
        {
            // Testeo que funcione el uso del hechizo
            double expected = 910;
            mywizard.UseSpell(spell1, otherwizard);

            Assert.That(expected, Is.EqualTo(otherwizard.health));
        }  
        [Test]
        public void UseSpellTest2()
        {
            // Testeo que si el hechizo no esta en el libro de mywizard, otherwizard no pierda vida
            Spell spell4 = new Spell("bomba", 70, 5);
            double expected = 1000;
            mywizard.UseSpell(spell4, otherwizard);

            Assert.That(expected, Is.EqualTo(otherwizard.health));
        }
        [Test]
        public void UseMagicClubTest1()
        {
            // Testeo que funcione al ataque con el Bastón Mágico
            double expected = 915;
            mywizard.UseMagicClub(otherwizard);

            Assert.That(expected, Is.EqualTo(otherwizard.health));
        }
        [Test]
        public void UseMagicClubTest2()
        {
            // Testeo que funcione el ataque con otros personajes con distintos valores de defensa
            double expected = 950;
            mywizard.UseMagicClub(dwarf);

            Assert.That(expected, Is.EqualTo(dwarf.health));
        }
/*
        [Test]
        public void HealTest1()
        {
            // Testeo que la capacidad de recuperar vida funcione
            double expected = 935;
            mywizard.UseMagicClub(otherwizard);
            mywizard.UseSpell(spell1, otherwizard);
            otherwizard.Heal(70);

            Assert.That(expected, Is.EqualTo(otherwizard.health));
        }
        [Test]
        public void HealTest2()
        {
            // Testeo que la vida no se pase del valor máximo, que es 1000
            double expected = 1000;
            mywizard.UseMagicClub(otherwizard);
            mywizard.UseSpell(spell1, otherwizard);
            otherwizard.Heal(300);

            Assert.That(expected, Is.EqualTo(otherwizard.health));
        }
        [Test]
        public void GetTotalDamageTest()
        {
            // Testeo que funcione el método GetTotalDamage()
            double expected = 155;

            Assert.That(expected, Is.EqualTo(mywizard.attackvalue));
        }
        [Test]
        public void GetTotalDefenseTest()
        {
            // Testeo que funcione el método GetTotalDefense()
            double expected = 135;

            Assert.That(expected, Is.EqualTo(mywizard.attackvalue));
        }
        [Test]
        public void RestoreHealthTest()
        {
            double expected = 1000;
            mywizard.UseSpell(spell1, otherwizard);
            mywizard.UseSpell(spell2, otherwizard);
            mywizard.UseMagicClub(otherwizard);
            otherwizard.RestoreHealth();

            Assert.That(expected, Is.EqualTo(otherwizard.health));
        }
*/
    }
}