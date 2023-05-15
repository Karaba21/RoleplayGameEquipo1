using System;
using System.Collections.Generic;
using Library;
using NUnit.Framework;
/*
namespace Library.Test
{
    public class DwarfTest
    {
        // En esta clase hay 14 tests.
        private Wizard wizard;
        private Dwarf dwarf1;
        private Dwarf dwarf2;
        private Elf elf;
        [SetUp]
        public void SetUp()
        {
            wizard = new Wizard("Merlin");
            dwarf1 = new Dwarf("Grumpy");
            dwarf2 = new Dwarf("Dopey");
            elf = new Elf("Sombrio");
        }
        [Test]
        public void UseCrossbowOnWizardTest()
        {
            double expected = 940;
            dwarf1.UseCrossbow(wizard);

            Assert.That(expected, Is.EqualTo(wizard.health));
        }
        [Test]
        public void UseCrossbowOnDwarfTest()
        {
            double expected = 940;
            dwarf1.UseCrossbow(dwarf2);

            Assert.That(expected, Is.EqualTo(dwarf2.health));
        }
        [Test]
        public void UseCrossbowOnElfTest()
        {
            double expected = 940;
            dwarf1.UseCrossbow(elf);

            Assert.That(expected, Is.EqualTo(elf.health));
        }
        [Test]
        public void UseDaggersOnWizardTest()
        {
            double expected = 945;
            dwarf1.UseDaggers(wizard);

            Assert.That(expected, Is.EqualTo(wizard.health));
        }
        [Test]
        public void UseDaggersOnDwarfTest()
        {
            double expected = 945;
            dwarf1.UseDaggers(dwarf2);

            Assert.That(expected, Is.EqualTo(dwarf2.health));
        }
        [Test]
        public void UseDaggersOnElfTest()
        {
            double expected = 945;
            dwarf1.UseDaggers(elf);

            Assert.That(expected, Is.EqualTo(elf.health));
        }
        [Test]
        public void HealTest1()
        {
            double expected = 875;
            wizard.UseMagicClub(dwarf1);
            dwarf2.UseCrossbow(dwarf1);
            dwarf2.UseDaggers(dwarf1);
            dwarf1.Heal(40);

            Assert.That(expected, Is.EqualTo(dwarf1.health));
        }
        [Test]
        public void HealTest2()
        {
            double expected = 1000;
            wizard.UseMagicClub(dwarf1);
            dwarf2.UseCrossbow(dwarf1);
            dwarf2.UseDaggers(dwarf1);
            dwarf1.Heal(400);

            Assert.That(expected, Is.EqualTo(dwarf1.health));
        }
        [Test]
        public void RestoreHealthTest()
        {
            double expected = 1000;
            wizard.UseMagicClub(dwarf2);
            elf.UseFireBalls(dwarf2);
            dwarf1.UseScythe(dwarf2);
            dwarf2.RestoreHealth();

            Assert.That(expected, Is.EqualTo(dwarf2.health));
        }
        [Test]
        public void ActivateDynamiteTest()
        {
            double expected = 380;
            dwarf1.ActivateDynamite();

            Assert.That(expected, Is.EqualTo(dwarf1.attackvalue));
        }
        [Test]
        public void DeactivateDynamiteTest1()
        {
            double expected = 190;
            dwarf1.ActivateDynamite();
            dwarf1.DeactivateDynamite();

            Assert.That(expected, Is.EqualTo(dwarf1.attackvalue));
        }
        [Test]
        public void DeactivateDynamiteTest2()
        {
            double expected = 880;
            dwarf1.ActivateDynamite();
            dwarf1.UseCrossbow(dwarf2);

            Assert.That(expected, Is.EqualTo(dwarf2.health));
        }
    }
}
*/