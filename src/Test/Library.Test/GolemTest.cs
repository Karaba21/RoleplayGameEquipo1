using System;
using Library;
using System.Collections.Generic;
using NUnit.Framework;

namespace Library.Test
{
    public class GolemTest
    {
        // Esta clase tiene 6 tests.
        public Golem golem;
        public Dwarf dwarf;
        
        [SetUp]
        public void SetUp()
        {
            golem = new Golem("Rocky"); // defense = 60
            dwarf = new Dwarf("Ren"); // defense = 40
        }
        [Test]
        public void GetTotalDamageTest()
        {
            // Verifico que la cuenta de totalDamage funcione
            double expected = 160;

            Assert.That(expected, Is.EqualTo(golem.totalDamage));
        }
        [Test]
        public void GetTotalDefenseTest()
        {
            // Verifico que la cuenta de totalDefense funcione
            double expected = 60;

            Assert.That(expected, Is.EqualTo(golem.totalDefense));
        }
        [Test]
        public void UseFists()
        {
            // Testeo que funcione el ataque de Fists
            double expected = 980;
            golem.UseFists(dwarf);

            Assert.That(expected, Is.EqualTo(dwarf.health));
        }
        [Test]
        public void UseGolemite()
        {
            // Testeo que funcione el ataque Golemite
            double expected = 980;
            golem.UseGolemite(dwarf);

            Assert.That(expected, Is.EqualTo(dwarf.health));
        }
        [Test]
        public void UseStones()
        {
            // Testeo que funcione el ataque Stones
            double expected = 1000;
            golem.UseStones(dwarf);

            Assert.That(expected, Is.EqualTo(dwarf.health));
        }
        [Test]
        public void UseAllStrengthTest()
        {
            // Testeo que funcione el método UseAllStrength()
            double expected = 880;
            golem.UseAllStrength(dwarf);

            Assert.That(expected, Is.EqualTo(dwarf.health));
        }
    }
}
    