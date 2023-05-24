using System;
using Library;
using System.Collections.Generic;
using NUnit.Framework;

namespace Library.Test
{
    public class ElfTest
    {
        // En esta clase hay 10 tests.
        private Elf elf;
        private Elf otherElf;
        private Golem golem;
        [SetUp]
        public void SetUp()
        {
            elf = new Elf("Sombrio"); // defense = 55
            otherElf = new Elf("Dobby"); // defense = 55
            golem = new Golem("Strix"); // defense = 60
        }
        [Test]
        public void GetTotalDamageTest()
        {
            // Verifico que la cuenta de totalDamage funcione
            double expected = 175;

            Assert.That(expected, Is.EqualTo(elf.totalDamage));
        }
        [Test]
        public void GetTotalDefenseTest()
        {
            // Verifico que la cuenta de totalDefense funcione
            double expected = 55;

            Assert.That(expected, Is.EqualTo(elf.totalDefense));
        }
        [Test]
        public void UseFireBallsTest() // damage = 85
        {
            // Testeo que funcione el ataque con Bolas de Fuego
            double expected = 975;
            elf.UseFireBalls(golem);

            Assert.That(expected, Is.EqualTo(golem.health));
        }
        [Test]
        public void UseWhirlWindTest() // damage = 90
        {
            // Testeo que funcione el ataque con Tornado
            double expected = 970;
            elf.UseWhirlWind(golem);

            Assert.That(expected, Is.EqualTo(golem.health));
        }
        [Test]
        public void HealTest1()
        {
            // Testeo que la capacidad de recuperar vida funcione
            double expected = 925;
            golem.UseAllStrength(elf); // health = 895
            elf.Heal(30);

            Assert.That(expected, Is.EqualTo(elf.health));
        }
        [Test]
        public void HealTest2()
        {
            // Testeo que la vida no se pase del valor máximo, que es 1000
            double expected = 1000;
            golem.UseFists(elf);
            elf.Heal(500);

            Assert.That(expected, Is.EqualTo(elf.health));
        }
        [Test]
        public void RestoreHealthTest()
        {
            // Testeo que funcione el método RestoreHealth()
            double expected = 1000;
            golem.UseAllStrength(elf);
            golem.UseAllStrength(elf);
            golem.UseAllStrength(elf);
            elf.RestoreHealth();

            Assert.That(expected, Is.EqualTo(elf.health));
        }
        [Test]
        public void UseAllStrengthTest() // damage = 175
        {
            // Testeo que funcione el método UseAllStrength()
            double expected = 885;
            elf.UseAllStrength(golem);

            Assert.That(expected, Is.EqualTo(golem.health));
        }
        [Test]
        public void HealOtherTest1()
        {
            // Testeo que funcione la curación a otro personaje
            double expected = 905;
            golem.UseAllStrength(otherElf); // health = 895
            elf.HealOther(otherElf, 10);

            Assert.That(expected, Is.EqualTo(otherElf.health));
        }
        [Test]
        public void HealOtherTest2()
        {
            // Testeo que la vida del elfo que cura a otro personaje aumente al hacerlo
            double expected = 900;
            golem.UseAllStrength(otherElf);
            golem.UseAllStrength(elf); // health = 895
            elf.HealOther(otherElf, 10);

            Assert.That(expected, Is.EqualTo(elf.health));
        }
    }
}