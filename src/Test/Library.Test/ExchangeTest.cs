using System;
using Library;
using System.Collections.Generic;
using NUnit.Framework;

namespace Library.Test
{
    public class ExchangeTest
    {
        private Exchange exchange;
        private Heroes giver;
        private Heroes receiver;
        private Labrys labrys;
        private GauntletOfPower gauntlet;
        private List<IItems> items;
        [SetUp]
        public void SetUp()
        {
            giver = new Dwarf("Grumpy");
            receiver = new Elf("Dobby");

            labrys = new Labrys();
            gauntlet = new GauntletOfPower();

            items = new List<IItems>();

            giver.AddItem(labrys);
            giver.AddItem(gauntlet);

            items.Add(labrys);
            items.Add(gauntlet);

            exchange = new Exchange(giver, receiver, items);
        }
        [Test]
        public void DoEncounterTest()
        {
            bool expected = true;
            exchange.DoEncounter();

            Assert.That(expected, Is.EqualTo((receiver.items.Contains(labrys) && receiver.items.Contains(gauntlet))));
        }
    }
}