using System;
using System.Collections.Generic;
using Library;
using NUnit.Framework;

namespace Library.Test
{
    public class DarkWizardTest
    {
        // Esta clase tiene 6 tests
        private DarkWizard darkWizard;
        private Dwarf dwarf;
        [SetUp]
        public void SetUp()
        {
            dwarf = new Dwarf("Tommy"); // defense = 40
            darkWizard = new DarkWizard("Eladio"); // defense = 40
        }
        [Test]
        public void GetTotalDamageTest()
        {
            // Verifico que la cuenta de totalDamage funcione
            double expected = 245;

            Assert.That(expected, Is.EqualTo(darkWizard.totalDamage));
        }
        [Test]
        public void GetTotalDefenseTest()
        {
            // Verifico que la cuenta de totalDefense funcione
            double expected = 40;

            Assert.That(expected, Is.EqualTo(darkWizard.totalDefense));
        }
        [Test]
        public void UseDaggersTest() // damage = 70
        {
            // Testeo que funcione el ataque con Dagas
            double expected = 970;
            darkWizard.UseDaggers(dwarf);

            Assert.That(expected, Is.EqualTo(dwarf.health));
        }
        [Test]
        public void UseFireBallsTest()// damage 85
        {
            // Testeo que funcionen el ataque con las Bolas de Fuego
            double expected = 955;
            darkWizard.UseFireBalls(dwarf);

            Assert.That(expected, Is.EqualTo(dwarf.health));
        }
        [Test]
        public void UseScytheTest() // damage = 90
        {
            // Testeo que funcione el ataque con Guadaña
            double expected = 950;
            darkWizard.UseScythe(dwarf);

            Assert.That(expected, Is.EqualTo(dwarf.health));
        }   
        [Test]
        public void UseAllStrengthTest()
        {
            // Testeo que funcione el método UseAllStrength()
            double expected = 795;
            darkWizard.UseAllStrength(dwarf);

            Assert.That(expected, Is.EqualTo(dwarf.health));
        }
    }    
}