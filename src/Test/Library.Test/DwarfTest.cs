using System;
using System.Collections.Generic;
using Library;
using NUnit.Framework;

namespace Library.Test
{
    public class DwarfTest
    {
        // En esta clase hay 16 tests.
        private Wizard wizard;
        private Dwarf dwarf;
        private Dwarf otherdwarf;
        private Elf elf;
        private Spell spell;
        [SetUp]
        public void SetUp()
        {
            wizard = new Wizard("Merlin"); // defense = 50
            dwarf = new Dwarf("Grumpy"); // defense = 40
            otherdwarf = new Dwarf("Dopey"); // defense = 40
            elf = new Elf("Sombrio"); // defense = 70
            spell = new Spell("escudo", 0, 40);

            wizard.spellbook.AddSpell(spell);
        }
        [Test]
        public void GetTotalDamageTest()
        {
            // Verifico que la cuenta de totaldamage funcione
            double expected = 240;

            Assert.That(expected, Is.EqualTo(dwarf.totaldamage));
        }
        [Test]
        public void GetTotalDefenseTest()
        {
            // Verifico que la cuenta de totaldefense funcione
            double expected = 40;

            Assert.That(expected, Is.EqualTo(dwarf.totaldefense));
        }
        [Test]
        public void UseCrossbowTest1() // damage = 80
        {
            // Testeo que funcione el ataque con Ballesta
            double expected = 970;
            dwarf.UseCrossbow(wizard);

            Assert.That(expected, Is.EqualTo(wizard.health));
        }
        [Test]
        public void UseCrossbowTest2() // damage = 80
        {
            // Testeo que funcione el ataque con Ballesta en personajes con valores de defensa distintos
            double expected = 960;
            dwarf.UseCrossbow(otherdwarf);

            Assert.That(expected, Is.EqualTo(otherdwarf.health));
        }
        [Test]
        public void UseDaggersTest1() // damage = 70
        {
            // Testeo que funcione el ataque con Dagas
            double expected = 1000;
            dwarf.UseDaggers(elf);

            Assert.That(expected, Is.EqualTo(elf.health));
        }
        [Test]
        public void UseDaggersTest2() // damage = 70
        {
            // Testeo que funcione el ataque con Dagas en personajes con valores de defensa distintos
            double expected = 980;
            dwarf.UseDaggers(wizard);

            Assert.That(expected, Is.EqualTo(wizard.health));
        }
        [Test]
        public void UseScytheTest1() // damage = 90
        {
            // Testeo que funcione el ataque con Guadaña
            double expected = 980;
            dwarf.UseScythe(elf);

            Assert.That(expected, Is.EqualTo(elf.health));
        }
        [Test]
        public void UseScytheTest2() // damage = 90
        {
            // Testeo que funcione el ataque con Guadaña en personajes con valores de defensa distintos
            double expected = 950;
            dwarf.UseScythe(otherdwarf);

            Assert.That(expected, Is.EqualTo(otherdwarf.health));
        }
        [Test]
        public void HealTest1()
        {
            // Testeo que la capacidad de recuperar vida funcione
            double expected = 950;
            otherdwarf.UseCrossbow(dwarf);
            otherdwarf.UseScythe(dwarf);
            dwarf.Heal(40);

            Assert.That(expected, Is.EqualTo(dwarf.health));
        }
        [Test]
        public void HealTest2()
        {
            // Testeo que la vida no se pase del valor máximo, que es 1000
            double expected = 1000;
            otherdwarf.UseCrossbow(dwarf);
            otherdwarf.UseDaggers(dwarf);
            dwarf.Heal(400);

            Assert.That(expected, Is.EqualTo(dwarf.health));
        }
        [Test]
        public void RestoreHealthTest()
        {
            // Testeo que funcione el método RestoreHealth()
            double expected = 1000;
            dwarf.UseScythe(otherdwarf);
            dwarf.UseCrossbow(otherdwarf);
            dwarf.UseDaggers(otherdwarf);
            otherdwarf.RestoreHealth();

            Assert.That(expected, Is.EqualTo(otherdwarf.health));
        }
        [Test]
        public void UseAllStrengthTest()
        {
            // Testeo que funcione el método UseAllStrength()
            double expected = 800;
            dwarf.UseAllStrength(otherdwarf);

            Assert.That(expected, Is.EqualTo(otherdwarf.health));
        }
        [Test]
        public void ActivateDynamiteTest1()
        {
            // Testeo que funcione el método ActivateDynamite() y que totaldamage aumente
            double expected = 480;
            dwarf.ActivateDynamite();

            Assert.That(expected, Is.EqualTo(dwarf.totaldamage));
        }
        [Test]
        public void ActivateDynamiteTest2()
        {
            // Testeo que funcione el método ActivateDynamite() y que totaldefense disminuya
            double expected = 20;
            dwarf.ActivateDynamite();

            Assert.That(expected, Is.EqualTo(dwarf.totaldefense));
        }
        [Test]
        public void DeactivateDynamiteTest1()
        {
            // Testeo que funcione el método DectivateDynamite() y que totaldamage disminuya
            double expected = 240;
            dwarf.ActivateDynamite();
            dwarf.DeactivateDynamite();

            Assert.That(expected, Is.EqualTo(dwarf.totaldamage));
        }
        [Test]
        public void DeactivateDynamiteTest2()
        {
            // Testeo que funcione el método DeactivateDynamite() y que totaldefense aumente
            double expected = 40;
            dwarf.ActivateDynamite();
            dwarf.DeactivateDynamite();

            Assert.That(expected, Is.EqualTo(dwarf.totaldefense));
        }
    }
}