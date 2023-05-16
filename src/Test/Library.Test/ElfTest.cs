using System;
using Library;
using System.Collections.Generic;
using NUnit.Framework;

namespace Library.Test
{
    public class ElfTest
    {
        // En esta clase hay 12 tests.
        private Wizard wizard;
        private Dwarf dwarf;
        private Elf elf;
        private Elf otherelf;
        [SetUp]
        public void SetUp()
        {
            wizard = new Wizard("Merlin"); // defense 50
            dwarf = new Dwarf("Grumpy"); // defense = 40
            elf = new Elf("Sombrio"); // defense = 70
            otherelf = new Elf("Dobby"); // defense = 70
        }
        [Test]
        public void GetTotalDamageTest()
        {
            // Verifico que la cuenta de totaldamage funcione
            double expected = 175;

            Assert.That(expected, Is.EqualTo(elf.totaldamage));
        }
        [Test]
        public void GetTotalDefenseTest()
        {
            // Verifico que la cuenta de totaldefense funcione
            double expected = 70;

            Assert.That(expected, Is.EqualTo(elf.totaldefense));
        }
        [Test]
        public void UseFireBallsTest1() // damage = 85
        {
            // Testeo que funcione el ataque con Bolas de Fuego
            double expected = 985;
            elf.UseFireBalls(otherelf);

            Assert.That(expected, Is.EqualTo(otherelf.health));
        }
        [Test]
        public void UseFireBallsTest2() // damage = 85
        {
            // Testeo que funcione el ataque con Bolas de Fuego en personajes con valores de defensa distintos
            double expected = 955;
            elf.UseFireBalls(dwarf);

            Assert.That(expected, Is.EqualTo(dwarf.health));
        }
        [Test]
        public void UseWhirlWindTest1() // damage = 90
        {
            // Testeo que funcione al ataque con Tornado
            double expected = 955;
            elf.UseWhirlWind(wizard);

            Assert.That(expected, Is.EqualTo(wizard.health));
        }
        [Test]
        public void UseWhirlWindTest2() // damage = 90
        {
            // Testeo que funcione le ataque con Tornado en personajes con valores de defensa distintos
            double expected = 980;
            elf.UseWhirlWind(otherelf);

            Assert.That(expected, Is.EqualTo(otherelf.health));
        }
        [Test]
        public void HealTest1()
        {
            // Testeo que la capacidad de recuperar vida funcione
            double expected = 980;
            otherelf.UseFireBalls(elf);
            otherelf.UseWhirlWind(elf);
            otherelf.UseFireBalls(elf);
            elf.Heal(30);

            Assert.That(expected, Is.EqualTo(elf.health));
        }
        [Test]
        public void HealTest2()
        {
            // Testeo que la vida no se pase del valor máximo, que es 1000
            double expected = 1000;
            otherelf.UseFireBalls(elf);
            otherelf.UseWhirlWind(elf);
            elf.Heal(500);

            Assert.That(expected, Is.EqualTo(elf.health));
        }
        [Test]
        public void RestoreHealthTest()
        {
            // Testeo que funcione el método RestoreHealth()
            double expected = 1000;
            otherelf.UseFireBalls(elf);
            otherelf.UseFireBalls(elf);
            otherelf.UseWhirlWind(elf);
            otherelf.UseFireBalls(elf);
            otherelf.UseFireBalls(elf);
            otherelf.UseWhirlWind(elf);
            otherelf.UseFireBalls(elf);
            elf.RestoreHealth();

            Assert.That(expected, Is.EqualTo(elf.health));
        }
        [Test]
        public void UseAllStrengthTest() // damage = 175
        {
            // Testeo que funcione el método UseAllStrength()
            double expected = 870;
            elf.UseAllStrength(wizard);

            Assert.That(expected, Is.EqualTo(wizard.health));
        }
        [Test]
        public void HealOtherTest1()
        {
            // Testeo que funcione la curación a otro personaje
            double expected = 970;
            elf.UseFireBalls(wizard);
            elf.HealOther(wizard, 10);

            Assert.That(expected, Is.EqualTo(wizard.health));
        }
        [Test]
        public void HealOtherTest2()
        {
            // Testeo que la vida del elfo que cura a otro personaje aumente al hacerlo
            double expected = 990;
            elf.UseFireBalls(otherelf);
            elf.UseWhirlWind(dwarf);
            otherelf.HealOther(dwarf, 15);

            Assert.That(expected, Is.EqualTo(otherelf.health));
        }
    }
}