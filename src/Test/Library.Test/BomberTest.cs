using System;
using Library;
using System.Collections.Generic;
using NUnit.Framework;

namespace Library.Test
{
    public class BomberTest
    {
        // En esta clase hay 5 tests.
        private Dwarf dwarf;
        private Bomber bomber;
        [SetUp]
        public void SetUp()
        {
            dwarf = new Dwarf("Andy"); // defense = 40
            bomber= new Bomber("KongTheBomber"); // defemse = 65
        }
        [Test]
        public void GetTotalDamageTest()
        {
            // Verifico que la cuenta de totalDamage funcione
            double expected = 215;

            Assert.That(expected, Is.EqualTo(bomber.totalDamage));
        }
        [Test]
        public void GetTotalDefenseTest()
        {
            // Verifico que la cuenta de totalDefense funcione
            double expected = 65;

            Assert.That(expected, Is.EqualTo(bomber.totalDefense));
        }
        [Test]
        public void UseScytheTest()
        {
            // Testeo que funcione el ataque con Guadaña
            double expected = 950;
            bomber.UseScythe(dwarf);

            Assert.That(expected, Is.EqualTo(dwarf.health));
        }
        [Test]
        public void UseBombsTest()
        {
            // Testeo que funcione el ataque con las Bombas
            double expected = 915;
            bomber.UseBombs(dwarf);
            Assert.That(expected, Is.EqualTo(dwarf.health));
        }   
        [Test]
        public void UseAllStrengthTest()
        {
            // Testeo que funcione el método UseAllStrength()
            double expected = 825;
            bomber.UseAllStrength(dwarf);

            Assert.That(expected, Is.EqualTo(dwarf.health));
        }
    }
}