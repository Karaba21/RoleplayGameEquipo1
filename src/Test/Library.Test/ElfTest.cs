using System;
using Library;
using System.Collections.Generic;
using NUnit.Framework;
/*
namespace Library.Test
{
    public class ElfTest
    {
        // En esta clase hay 14 tests.
        private Wizard wizard;
        private Dwarf dwarf;
        private Elf elf;
        private Elf otherelf;
        [SetUp]
        public void SetUp()
        {
            wizard = new Wizard("Merlin");
            dwarf = new Dwarf("Grumpy");
            elf= new Elf("Sombrio");
            otherelf = new Elf("Dobby");
        }
        [Test]
        public void UseFireBallsOnWizardTest()
        {
            double expected = 930;
            elf.UseFireBalls(wizard);

            Assert.That(expected, Is.EqualTo(wizard.health));
        }
        [Test]
        public void UseFireBallsOnDwarfTest()
        {
            double expected = 930;
            elf.UseFireBalls(dwarf);

            Assert.That(expected, Is.EqualTo(dwarf.health));
        }
        [Test]
        public void UseFireBallsOnElfTest()
        {
            double expected = 930;
            elf.UseFireBalls(otherelf);

            Assert.That(expected, Is.EqualTo(otherelf.health));
        }
        [Test]
        public void UseWhirlWindOnWizardTest()
        {
            double expected = 935;
            elf.UseWhirlWind(wizard);

            Assert.That(expected, Is.EqualTo(wizard.health));
        }
        [Test]
        public void UseWhirlWindOnDwarfTest()
        {
            double expected = 935;
            elf.UseWhirlWind(dwarf);

            Assert.That(expected, Is.EqualTo(dwarf.health));
        }
        [Test]
        public void UseWhirlWindOnElfTest()
        {
            double expected = 935;
            elf.UseWhirlWind(otherelf);

            Assert.That(expected, Is.EqualTo(otherelf.health));
        }
        [Test]
        public void HealOtherWizardTest()
        {
            double expected = 980;
            elf.UseFireBalls(wizard);
            elf.HealOther(wizard, 50);

            Assert.That(expected, Is.EqualTo(wizard.health));
        }
        [Test]
        public void HealOtherDwarfTest()
        {
            double expected = 980;
            elf.UseFireBalls(dwarf);
            elf.HealOther(dwarf, 50);

            Assert.That(expected, Is.EqualTo(dwarf.health));
        }
        [Test]
        public void HealOtherElfTest()
        {
            double expected = 980;
            elf.UseFireBalls(otherelf);
            elf.HealOther(otherelf, 50);

            Assert.That(expected, Is.EqualTo(otherelf.health));
        }
        [Test]
        public void HealTest1()
        {
            double expected = 815;
            dwarf.UseCrossbow(elf);
            otherelf.UseFireBalls(elf);
            otherelf.UseWhirlWind(elf);
            wizard.UseMagicClub(elf);
            elf.Heal(60);

            Assert.That(expected, Is.EqualTo(elf.health));
        }
        [Test]
        public void HealTest2()
        {
            double expected = 1000;
            dwarf.UseCrossbow(elf);
            otherelf.UseFireBalls(elf);
            otherelf.UseWhirlWind(elf);
            wizard.UseMagicClub(elf);
            elf.Heal(500);

            Assert.That(expected, Is.EqualTo(elf.health));
        }
        [Test]
        public void RestoreHealthTest()
        {
            double expected = 1000;
            wizard.UseMagicClub(elf);
            otherelf.UseFireBalls(elf);
            dwarf.UseDaggers(elf);
            elf.RestoreHealth();

            Assert.That(expected, Is.EqualTo(elf.health));
        }
    }
}
*/