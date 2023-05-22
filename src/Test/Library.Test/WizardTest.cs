using System;
using Library;
using System.Collections.Generic;
using NUnit.Framework;

namespace Library.Test
{
    public class WizardTest
    {
        // En esta clase hay 12 tests.
        private Wizard wizard;
        private Wizard otherWizard;
        private Spell spell1;
        private Spell spell2;
        private Spell spell3;
        private Bomber bomber;
        [SetUp]
        public void SetUp()
        {
            wizard = new Wizard("Merlin"); // defense = 80
            otherWizard = new Wizard("Houdini"); // defense = 45
            bomber = new Bomber("Bombastic"); // defense = 65
            spell1 = new Spell("ataque", 65, 0);
            spell2 = new Spell("golpe", 20, 0);
            spell3 = new Spell("escudo", 0, 30);

            wizard.item1.AddSpell(spell1);
            wizard.item1.AddSpell(spell2);
            wizard.item1.AddSpell(spell3);
        }
        [Test]
        public void GetTotalDamageTest()
        {
            // Verifico que la cuenta de totaldamage funcione
            double expected = 220;

            Assert.That(expected, Is.EqualTo(wizard.totalDamage));
        }
        [Test]
        public void GetTotalDefenseTest()
        {
            // Verifico que la cuenta de totaldefense funcione
            double expected = 90;

            Assert.That(expected, Is.EqualTo(wizard.totalDefense));
        }
        [Test]
        public void UseSpellTest1() // damage = 80
        {
            // Testeo que funcione el uso del hechizo
            double expected = 955;
            wizard.UseSpell(spell1, bomber);

            Assert.That(expected, Is.EqualTo(bomber.health));
        }  
        [Test]
        public void UseSpellTest2()
        {
            // Testeo que si el hechizo no esta en el libro de mywizard, otherwizard no pierda vida
            Spell spell4 = new Spell("explosion", 70, 5);
            double expected = 1000;
            wizard.UseSpell(spell4, bomber);

            Assert.That(expected, Is.EqualTo(bomber.health));
        }
        [Test]
        public void UseMagicClubTest() // damage = 90
        {
            // Testeo que funcione al ataque con el Bastón Mágico
            double expected = 975;
            wizard.UseMagicClub(bomber);

            Assert.That(expected, Is.EqualTo(bomber.health));
        }
        [Test]
        public void HealTest1()
        {
            // Testeo que la capacidad de recuperar vida funcione
            double expected = 945;
            bomber.UseAllStrength(wizard);
            wizard.Heal(70);

            Assert.That(expected, Is.EqualTo(wizard.health));
        }
        [Test]
        public void HealTest2()
        {
            // Testeo que la vida no se pase del valor máximo, que es 1000
            double expected = 1000;
            bomber.UseAllStrength(wizard);
            wizard.Heal(300);

            Assert.That(expected, Is.EqualTo(wizard.health));
        }
        [Test]
        public void RestoreHealthTest()
        {
            // Testeo que funcione el método RestoreHealth()
            double expected = 1000;
            bomber.UseAllStrength(wizard);
            bomber.UseAllStrength(wizard);
            wizard.RestoreHealth();

            Assert.That(expected, Is.EqualTo(wizard.health));
        }
        [Test]
        public void UseAllStrengthTest() // damage = 220
        {
            // Testeo que funcione el método UseAllStrength()
            double expected = 845;
            wizard.UseAllStrength(bomber);

            Assert.That(expected, Is.EqualTo(bomber.health));
        }
        [Test]
        public void AddItemTest()
        {
            // Testeo que se le puedan otorgar elementos a un personaje
            bool expected = true;
            Shield shield = new Shield();
            wizard.AddItem(shield);

            Assert.That(expected, Is.EqualTo(wizard.items.Contains(shield)));
        }
        [Test]
        public void RemoveItemTest1()
        {
            // Testeo que se le puedan quitar elementos a un personaje
            bool expected = false;
            Scythe scythe = new Scythe();
            wizard.AddItem(scythe);
            wizard.RemoveItem(scythe);

            Assert.That(expected, Is.EqualTo(wizard.items.Contains(scythe)));
        }
        [Test]
        public void RemoveItemTest2()
        {
            // Testeo que no se le puedan quitar los elementos iniciales a un personaje
            bool expected = true;
            wizard.RemoveItem(wizard.item2);

            Assert.That(expected, Is.EqualTo(wizard.items.Contains(wizard.item2)));
        }
    }
}