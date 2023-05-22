using System;
using Library;
using System.Collections.Generic;
using NUnit.Framework;

namespace Library.Test
{
    public class WizardTest
    {
        // En esta clase hay 12 tests.
        private Wizard mywizard;
        private Wizard otherwizard;
        private Spell spell1;
        private Spell spell2;
        private Spell spell3;
        private Bomber bomber;
        [SetUp]
        public void SetUp()
        {
            mywizard = new Wizard("Merlin"); // defense = 50
            otherwizard = new Wizard("Houdini"); // defense = 5
            bomber = new Bomber("Bombastic"); // 80
            spell1 = new Spell("ataque", 65, 0);
            spell2 = new Spell("golpe", 20, 0);
            spell3 = new Spell("escudo", 0, 30);

            mywizard.item1.AddSpell(spell1);
            mywizard.item1.AddSpell(spell2);
            mywizard.item1.AddSpell(spell3);
        }
        [Test]
        public void GetTotalDamageTest()
        {
            // Verifico que la cuenta de totaldamage funcione
            double expected = 220;

            Assert.That(expected, Is.EqualTo(mywizard.totaldamage));
        }
        [Test]
        public void GetTotalDefenseTest()
        {
            // Verifico que la cuenta de totaldefense funcione
            double expected = 90;

            Assert.That(expected, Is.EqualTo(mywizard.totaldefense));
        }
        [Test]
        public void UseSpellTest1()
        {
            // Testeo que funcione el uso del hechizo
            double expected = 970;
            mywizard.UseSpell(spell1, bomber);

            Assert.That(expected, Is.EqualTo(bomber.health));
        }  
        [Test]
        public void UseSpellTest2()
        {
            // Testeo que si el hechizo no esta en el libro de mywizard, otherwizard no pierda vida
            Spell spell4 = new Spell("explosion", 70, 5);
            double expected = 1000;
            mywizard.UseSpell(spell4, bomber);

            Assert.That(expected, Is.EqualTo(bomber.health));
        }
        [Test]
        public void UseMagicClubTest() // damage = 90
        {
            // Testeo que funcione al ataque con el Bastón Mágico
            double expected = 990;
            mywizard.UseMagicClub(bomber);

            Assert.That(expected, Is.EqualTo(bomber.health));
        }
        [Test]
        public void HealTest1()
        {
            // Testeo que la capacidad de recuperar vida funcione
            double expected = 945;
            bomber.UseAllStrength(mywizard);
            mywizard.Heal(70);

            Assert.That(expected, Is.EqualTo(mywizard.health));
        }
        [Test]
        public void HealTest2()
        {
            // Testeo que la vida no se pase del valor máximo, que es 1000
            double expected = 1000;
            bomber.UseAllStrength(mywizard);
            mywizard.Heal(300);

            Assert.That(expected, Is.EqualTo(mywizard.health));
        }
        [Test]
        public void RestoreHealthTest()
        {
            // Testeo que funcione el método RestoreHealth()
            double expected = 1000;
            bomber.UseAllStrength(mywizard);
            bomber.UseAllStrength(mywizard);
            mywizard.RestoreHealth();

            Assert.That(expected, Is.EqualTo(mywizard.health));
        }
        [Test]
        public void UseAllStrengthTest()
        {
            // Testeo que funcione el método UseAllStrength()
            double expected = 860;
            mywizard.UseAllStrength(bomber);

            Assert.That(expected, Is.EqualTo(bomber.health));
        }
        [Test]
        public void AddItemTest()
        {
            // Testeo que se le puedan otorgar elementos a un personaje
            bool expected = true;
            Shield shield = new Shield();
            mywizard.AddItem(shield);

            Assert.That(expected, Is.EqualTo(mywizard.items.Contains(shield)));
        }
        [Test]
        public void RemoveItemTest1()
        {
            // Testeo que se le puedan quitar elementos a un personaje
            bool expected = false;
            Scythe scythe = new Scythe();
            mywizard.AddItem(scythe);
            mywizard.RemoveItem(scythe);

            Assert.That(expected, Is.EqualTo(mywizard.items.Contains(scythe)));
        }
        [Test]
        public void RemoveItemTest2()
        {
            // Testeo que no se le puedan quitar los elementos iniciales a un personaje
            bool expected = true;
            mywizard.RemoveItem(mywizard.item2);

            Assert.That(expected, Is.EqualTo(mywizard.items.Contains(mywizard.item2)));
        }
    }
}