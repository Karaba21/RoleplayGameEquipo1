using System;
using System.Collections.Generic;
using Library;
using NUnit.Framework;

namespace Library.Test
{
    public class DwarfTest
    {
        // En esta clase hay 13 tests.
        private Dwarf dwarf;
        private Dwarf otherDwarf;
        private DarkWizard darkWizard;
        [SetUp]
        public void SetUp()
        {
            dwarf = new Dwarf("Grumpy"); // defense = 40
            otherDwarf = new Dwarf("Dopey"); // defense = 40
            darkWizard = new DarkWizard("Cora"); // defense = 40
        }
        [Test]
        public void GetTotalDamageTest()
        {
            // Verifico que la cuenta de totalDamage funcione
            double expected = 240;

            Assert.That(expected, Is.EqualTo(dwarf.totalDamage));
        }
        [Test]
        public void GetTotalDefenseTest()
        {
            // Verifico que la cuenta de totalDefense funcione
            double expected = 40;

            Assert.That(expected, Is.EqualTo(dwarf.totalDefense));
        }
        [Test]
        public void UseCrossbowTest() // damage = 80
        {
            // Testeo que funcione el ataque con Ballesta
            double expected = 960;
            dwarf.UseCrossbow(darkWizard);

            Assert.That(expected, Is.EqualTo(darkWizard.health));
        }
        [Test]
        public void UseDaggersTest() // damage = 70
        {
            // Testeo que funcione el ataque con Dagas
            double expected = 970;
            dwarf.UseDaggers(darkWizard);

            Assert.That(expected, Is.EqualTo(darkWizard.health));
        }
        [Test]
        public void UseScytheTest() // damage = 90
        {
            // Testeo que funcione el ataque con Guadaña
            double expected = 950;
            dwarf.UseScythe(darkWizard);

            Assert.That(expected, Is.EqualTo(darkWizard.health));
        }
        [Test]
        public void HealTest1()
        {
            // Testeo que la capacidad de recuperar vida funcione
            double expected = 945;
            darkWizard.UseFireBalls(dwarf); // health = 955
            darkWizard.UseScythe(dwarf); // health = 905
            dwarf.Heal(40);

            Assert.That(expected, Is.EqualTo(dwarf.health));
        }
        [Test]
        public void HealTest2()
        {
            // Testeo que la vida no se pase del valor máximo, que es 1000
            double expected = 1000;
            darkWizard.UseScythe(dwarf);
            darkWizard.UseDaggers(dwarf);
            dwarf.Heal(400);

            Assert.That(expected, Is.EqualTo(dwarf.health));
        }
        [Test]
        public void RestoreHealthTest()
        {
            // Testeo que funcione el método RestoreHealth()
            double expected = 1000;
            darkWizard.UseScythe(dwarf);
            darkWizard.UseFireBalls(dwarf);
            darkWizard.UseDaggers(dwarf);
            dwarf.RestoreHealth();

            Assert.That(expected, Is.EqualTo(dwarf.health));
        }
        [Test]
        public void UseAllStrengthTest()
        {
            // Testeo que funcione el método UseAllStrength()
            double expected = 800;
            dwarf.UseAllStrength(darkWizard);

            Assert.That(expected, Is.EqualTo(darkWizard.health));
        }
        [Test]
        public void ActivateDynamiteTest1()
        {
            // Testeo que funcione el método ActivateDynamite() y que totalDamage aumente
            double expected = 480;
            dwarf.ActivateDynamite();

            Assert.That(expected, Is.EqualTo(dwarf.totalDamage));
        }
        [Test]
        public void ActivateDynamiteTest2()
        {
            // Testeo que funcione el método ActivateDynamite() y que totalDefense disminuya
            double expected = 20;
            dwarf.ActivateDynamite();

            Assert.That(expected, Is.EqualTo(dwarf.totalDefense));
        }
        [Test]
        public void DeactivateDynamiteTest1()
        {
            // Testeo que funcione el método DectivateDynamite() y que totalDamage disminuya
            double expected = 240;
            dwarf.ActivateDynamite();
            dwarf.DeactivateDynamite();

            Assert.That(expected, Is.EqualTo(dwarf.totalDamage));
        }
        [Test]
        public void DeactivateDynamiteTest2()
        {
            // Testeo que funcione el método DeactivateDynamite() y que totalDefense aumente
            double expected = 40;
            dwarf.ActivateDynamite();
            dwarf.DeactivateDynamite();

            Assert.That(expected, Is.EqualTo(dwarf.totalDefense));
        }
    }
}