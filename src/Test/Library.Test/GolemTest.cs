using System;
using Library;
using System.Collections.Generic;
using NUnit.Framework;

namespace Library.Test
{
    public class GolemTest
    {
        public Golem golem;
        public Dwarf dwarf;
        
        [SetUp]
        public void SetUp()
        {
            golem = new Golem("Rocky"); // defense = 60
            dwarf = new Dwarf("Ren"); // defense = 40
        }

        [Test]
        public void UseFists()
        {
            // Testeo que funcione al ataque de Fists
            double expected = 940;
            golem.UseFists(dwarf);

            Assert.That(expected, Is.EqualTo(dwarf.health));
        }
        [Test]
        public void UseGolemite()
        {
            // Testeo que funcione al ataque Golemite
            double expected = 950;
            golem.UseGolemite(dwarf);

            Assert.That(expected, Is.EqualTo(dwarf.health));
        }
        [Test]
        public void UseStones()
        {
            // Testeo que funcione al ataque UseStones
            double expected = 960;
            golem.UseStones(dwarf);

            Assert.That(expected, Is.EqualTo(dwarf.health));
        }
        [Test]
        public void UseAllStrengthTest()
        {
            // Testeo que funcione el método UseAllStrength()
            double expected = 850;
            golem.UseAllStrength(dwarf);

            Assert.That(expected, Is.EqualTo(dwarf.health));
        }
    }
}
    