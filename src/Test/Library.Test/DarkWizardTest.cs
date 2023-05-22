using System;
using System.Collections.Generic;
using Library;
using NUnit.Framework;
namespace Library.Test
{
    public class DarkWizardTest
    {
        private DarkWizard darkWizard;
        private Dwarf dwarf;
        
        [SetUp]
        public void SetUp()
        {
            Dwarf dwarf = new Dwarf("Tommy"); // defense = 70
            DarkWizard darkWizard = new DarkWizard("Eladio"); // defense = 40
        }
        [Test]
        public void UseDaggersTest() // damage = 70
        {
            // Testeo que funcione el ataque con Dagas
            double expected = 1000;
            darkWizard.UseDaggers(dwarf);

            Assert.That(expected, Is.EqualTo(dwarf.health));
        }
        [Test]
        public void UseFireBallsTest()//damage 85 - 40=45.. 1000-45=955
        {
           double expected=955;
           darkWizard.UseFireBalls(dwarf);
           
            Assert.That(expected, Is.EqualTo(dwarf.health));
        }
        [Test]
        public void UseScytheTest() // damage = 90
        {
            // Testeo que funcione el ataque con Guadaña
            double expected = 950;
            darkWizard.UseScythe(dwarf);

            Assert.That(expected, Is.EqualTo(dwarf.health));
        }   
        [Test]
        public void GetTotalDamageTest()
        {
            // Verifico que la cuenta de totaldamage funcione
            double expected = 245;

            Assert.That(expected, Is.EqualTo(darkWizard.totalDamage));
        }
        [Test]
        public void GetTotalDefenseTest()
        {
            // Verifico que la cuenta de totaldefense funcione
            double expected = 40;

            Assert.That(expected, Is.EqualTo(darkWizard.totalDefense));
        }

    }    
}