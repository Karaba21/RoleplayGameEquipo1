using System;
using Library;
using System.Collections.Generic;
using NUnit.Framework;

namespace Library.Test
{
    public class WizardTest
    // En esta clase hay 14 tests.
    {
        private Wizard mywizard;
        private Wizard otherwizard;
        private Dwarf dwarf;
        private Elf elf;
        private Spell spell1;
        private Spell spell2;
        private Spell spell3;
        [SetUp]
        public void SetUp()
        {
            mywizard = new Wizard("Merlin"); // defense = 50
            otherwizard = new Wizard("Houdini"); // defense = 5
            dwarf = new Dwarf("Grumpy"); // defense = 40
            elf = new Elf("Sombrio"); // defense = 70
            spell1 = new Spell("ataque", 50, 0);
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
            double expected = 205;

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
            double expected = 950;
            mywizard.UseSpell(spell1, otherwizard);

            Assert.That(expected, Is.EqualTo(otherwizard.health));
        }  
        [Test]
        public void UseSpellTest2()
        {
            // Testeo que si el hechizo no esta en el libro de mywizard, otherwizard no pierda vida
            Spell spell4 = new Spell("bomba", 70, 5);
            double expected = 1000;
            mywizard.UseSpell(spell4, elf);

            Assert.That(expected, Is.EqualTo(elf.health));
        }
        [Test]
        public void UseSpellTest3()
        {
            // Testeo que funcione el ataque con otros personajes con distintos valores de defensa
            double expected = 945;
            mywizard.UseSpell(spell1, dwarf);

            Assert.That(expected, Is.EqualTo(dwarf.health));
        }
        [Test]
        public void UseMagicClubTest1() // damage = 90
        {
            // Testeo que funcione al ataque con el Bastón Mágico
            double expected = 955;
            mywizard.UseMagicClub(otherwizard);

            Assert.That(expected, Is.EqualTo(otherwizard.health));
        }
        [Test]
        public void UseMagicClubTest2() // damage = 90
        {
            // Testeo que funcione el ataque con otros personajes con distintos valores de defensa
            double expected = 950;
            mywizard.UseMagicClub(dwarf);

            Assert.That(expected, Is.EqualTo(dwarf.health));
        }
        [Test]
        public void HealTest1()
        {
            // Testeo que la capacidad de recuperar vida funcione
            double expected = 975;
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
        public void RestoreHealthTest()
        {
            // Testeo que funcione el método RestoreHealth()
            double expected = 1000;
            mywizard.UseSpell(spell1, otherwizard);
            mywizard.UseSpell(spell2, otherwizard);
            mywizard.UseMagicClub(otherwizard);
            otherwizard.RestoreHealth();

            Assert.That(expected, Is.EqualTo(otherwizard.health));
        }
        [Test]
        public void UseAllStrengthTest()
        {
            // Testeo que funcione el método UseAllStrength()
            double expected = 835;
            mywizard.UseAllStrength(dwarf);

            Assert.That(expected, Is.EqualTo(dwarf.health));
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