using System;
using Library;
using System.Collections.Generic;
using NUnit.Framework;

namespace Library.Test
{
    public class TrollTest
    {
        // Esta clase tiene 4 tests realizados.
        private Dwarf dwarf;
        private Troll troll;
        [SetUp]
        public void SetUp()
        {
            dwarf = new Dwarf("Monty"); // defense = 40
            troll = new Troll("Georgie"); // defense = 60
        }
        [Test]
        public void GetTotalDamageTest()
        {
            // Verifico que la cuenta de totalDamage funcione
            double expected = 110;

            Assert.That(expected, Is.EqualTo(troll.totalDamage));
        }
        [Test]
        public void GetTotalDefenseTest()
        {
            // Verifico que la cuenta de totalDefense funcione
            double expected = 60;

            Assert.That(expected, Is.EqualTo(troll.totalDefense));
        }
        [Test]
        public void UseStick() // damage = 55
        {
            // Testeo que funcione el ataque con el palo.
            double expected = 985;
            troll.UseStick(dwarf);

            Assert.That(expected, Is.EqualTo(dwarf.health));
        }
        [Test]
        public void UseAllStrengthTest()
        {
            // Testeo que funcione el método UseAllStrength()
            double expected = 930;
            troll.UseAllStrength(dwarf);

            Assert.That(expected, Is.EqualTo(dwarf.health));
        }
    }
}