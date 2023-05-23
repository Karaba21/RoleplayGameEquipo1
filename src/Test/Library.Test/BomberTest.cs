using System;
using Library;
using System.Collections.Generic;
using NUnit.Framework;

namespace Library.Test
{
    public class BomberTest
    {  
         private Dwarf dwarf;
        private Bomber bomber;
        [SetUp]
         public void SetUp()
        {
            dwarf = new Dwarf("Andy"); 
            bomber= new Bomber("KongTheBomber"); 
        }
        [Test]
        public void GetTotalDamageTest()
        {
            // Verifico que la cuenta de totaldamage funcione
            double expected = 215;

            Assert.That(expected, Is.EqualTo(bomber.totalDamage));
        }
        [Test]
        public void GetTotalDefenseTest()
        {
            // Verifico que la cuenta de totaldefense funcione
            double expected = 65;

            Assert.That(expected, Is.EqualTo(bomber.totalDefense));
        }
         public void UseScytheTest()
        {
            // Testeo que funcione el ataque con Guadaña
            double expected = 950;
            bomber.UseScythe(dwarf);

            Assert.That(expected, Is.EqualTo(dwarf.health));
        }   
         public void UseBombsTest()
        {
            // Testeo que funcione el ataque con las bombas
            double expected = 915;
            bomber.UseBombs(dwarf);
            Assert.That(expected, Is.EqualTo(dwarf.health));
        }   

    }
}