using System;
using Library;
using System.Collections.Generic;
using NUnit.Framework;

namespace Library.Test
{
    public class DarkKnightTest
    {
        //Esta clase tiene 
        private Dwarf dwarf;
        private DarkKnight darkKnight;

        [SetUp]
        public void SetUp()
        {
            dwarf = new Dwarf("Lore"); // defense = 40
            darkKnight= new DarkKnight("Charles"); // defense = 105
        }
        
        [Test]
        public void GetTotalDamageTest()
        {
            // Verifico que la cuenta de totaldamage funcione
            double expected = 160;

            Assert.That(expected, Is.EqualTo(darkKnight.totalDamage));
        }

        [Test]
        public void GetTotalDefenseTest()
        {
            // Verifico que la cuenta de totaldefense funcione
            double expected = 105;

            Assert.That(expected, Is.EqualTo(darkKnight.totalDefense));
        }
        [Test]
        public void UseSwordTest() // damage = 75
        {
            // Testeo que funcione el ataque con la Espada.
            double expected = 965;
            darkKnight.UseSword(dwarf);

            Assert.That(expected, Is.EqualTo(dwarf.health));
        }
        public void UseFlailTest() // damage = 85
        {
            // Testeo que funcione el ataque con Flail.
            double expected = 955;
            darkKnight.UseFlail(dwarf);

            Assert.That(expected, Is.EqualTo(darkKnight.health));
        }
        [Test]
        public void UseAllStrengthTest()
        {
            // Testeo que funcione el método UseAllStrength()
            double expected = 880;
            darkKnight.UseAllStrength(dwarf);

            Assert.That(expected, Is.EqualTo(dwarf.health));
        }
    }
}