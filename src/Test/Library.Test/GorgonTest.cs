using System;
using Library;
using System.Collections.Generic;
using NUnit.Framework;

namespace Library.Test
{
    public class GorgonTest
    {
        // En esta clase hay 6 tests.
        private Gorgon gorgon;
        private Dwarf dwarf;
        [SetUp]
        public void SetUp()
        {
            gorgon = new Gorgon("Medusa"); // defense = 65
            dwarf = new Dwarf("Grumpy"); // defense = 40
        }
        [Test]
        public void GetTotalDamageTest()
        {
            // Verifico que la cuenta de totaldamage funcione
            double expected = 190;
            
            Assert.That(expected, Is.EqualTo(gorgon.totalDamage));
        }
        [Test]
        public void GetTotalDefenseTest()
        {
            // Verifico que la cuenta de totaldefense funcione
            double expected = 65;

            Assert.That(expected, Is.EqualTo(gorgon.totalDefense));
        }
        [Test]
        public void UseSnakeHairTest()
        {
            // Testeo que funcione al ataque con las Serpientes en el pelo
            double expected = 980;
            gorgon.UseSnakeHair(dwarf);

            Assert.That(expected, Is.EqualTo(dwarf.health));
        }
        [Test]
        public void UseDeathStareTest()
        {
            // Testeo que funcione al ataque con la Mirada Petrificadora
            double expected = 935;
            gorgon.UseDeathStare(dwarf);

            Assert.That(expected, Is.EqualTo(dwarf.health));
        }
        [Test]
        public void UseTelePathicHissing()
        {
            // Testeo que funcione al ataque con el Silbido de Serpiente telepatico
            double expected = 1000;
            gorgon.UseTelepathicHissing(dwarf);

            Assert.That(expected, Is.EqualTo(dwarf.health));
        }
        [Test]
        public void UseAllStrengthTest()
        {
            // Testeo que funcione el método UseAllStrength()
            double expected = 850;
            gorgon.UseAllStrength(dwarf);

            Assert.That(expected, Is.EqualTo(dwarf.health));
        }
    }
}