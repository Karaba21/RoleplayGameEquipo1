using System;
using System.Collections.Generic;
using Library;
using NUnit.Framework;

namespace Library.Test
{
    public class EncounterTest
    {
        private Wizard wizard1;
        private Wizard wizard2;
        private Dwarf dwarf1;
        private Dwarf dwarf2;
        private Elf elf;
        private Bomber bomber;
        private DarkKnight darkKnight;
        private DarkWizard darkWizard;
        private Golem golem;
        private Gorgon gorgon;
        private Spell spell1;
        private Spell spell2;
        private Spell spell3;
        private List<Heroes> heroes;
        private List<Enemies> enemies;
        [SetUp]
        public void SetUp()
        {
            wizard1 = new Wizard("Merlin");
            wizard2 = new Wizard("Elsa");
            dwarf1 = new Dwarf("Grumpy");
            dwarf2 = new Dwarf("Dopey");
            elf = new Elf("Dobby");
            bomber = new Bomber("Bombastic");
            darkKnight = new DarkKnight("Leviathan");
            darkWizard = new DarkWizard("Rumpelstiltskin");
            golem = new Golem("Strix");
            gorgon = new Gorgon("Medusa");

            spell1 = new Spell("ataque", 65, 0);
            spell2 = new Spell("golpe", 20, 0);
            spell3 = new Spell("escudo", 0, 30);

            wizard1.item1.AddSpell(spell1);
            wizard1.item1.AddSpell(spell2);
            wizard1.item1.AddSpell(spell3);
            wizard2.item1.AddSpell(spell1);
            wizard2.item1.AddSpell(spell2);
            wizard2.item1.AddSpell(spell3);

            // heroes.AddRange(new List<Heroes>{wizard1, wizard2, dwarf1, dwarf2, elf});
            // enemies.AddRange(new List<Enemies>{bomber, darkKnight, darkWizard, golem, gorgon});
        }
        [Test]
        public void DoEncounterTest1()
        {
            // Caso en el que hay menos heroes que enemigos
            bool expected = true;
            int expectedrounds = 6;
            string expectedvictors = "h";
            heroes.AddRange(new List<Heroes>{wizard1, dwarf1, elf});
            enemies.AddRange(new List<Enemies>{bomber, darkKnight, darkWizard, golem, gorgon});
            // El método DoEncounter devolvería cuantas rondas duró
            int rounds;
            string victors;
            Encounter.DoEncounter(heroes, enemies, out rounds, out victors);
            bool success = (expectedrounds == rounds) && (expectedvictors == victors);
            
            Assert.That(expected, Is.EqualTo(success));
        }
        public void DoEncounterTest2()
        {
            // Caso en el que hay la misma cantidad de heroes que de enemigos
            bool expected = true;
            int expectedrounds = 4;
            string expectedvictors = "h";
            heroes.AddRange(new List<Heroes>{wizard1, wizard2, dwarf1, dwarf2, elf});
            enemies.AddRange(new List<Enemies>{bomber, darkKnight, darkWizard, golem, gorgon});

            int rounds;
            string victors;
            Encounter.DoEncounter(heroes, enemies, out rounds, out victors);
            bool success = (expectedrounds == rounds) && (expectedvictors == victors);
            
            Assert.That(expected, Is.EqualTo(success));   
        }
        public void DoEncounterTest3()
        {
            // Caso en el que hay la misma cantidad de heroes que de enemigos
            bool expected = true;
            int expectedrounds = 4;
            string expectedvictors = "h";
            heroes.AddRange(new List<Heroes>{wizard1, wizard2, dwarf1, dwarf2, elf});
            enemies.AddRange(new List<Enemies>{bomber, darkKnight, golem});

            int rounds;
            string victors;
            Encounter.DoEncounter(heroes, enemies, out rounds, out victors);
            bool success = (expectedrounds == rounds) && (expectedvictors == victors);
            
            Assert.That(expected, Is.EqualTo(success));   
        }
    }
}