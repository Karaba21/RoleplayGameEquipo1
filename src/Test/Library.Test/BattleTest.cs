using System;
using System.Collections.Generic;
using Library;
using NUnit.Framework;

namespace Library.Test
{
    public class BattleTest
    {
        // En esta clase hay 7 tests.
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
        private Spell w1Spell1;
        private Spell w1Spell2;
        private Spell w1Spell3;
        private Spell w2Spell1;
        private Spell w2Spell2;
        private Spell w2Spell3;
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

            w1Spell1 = wizard1.item1.AddSpell("ataque", 65, 0);
            w1Spell2 = wizard1.item1.AddSpell("golpe", 20, 0);
            w1Spell3 = wizard1.item1.AddSpell("escudo", 0, 30);

            w2Spell1 = wizard2.item1.AddSpell("ataque", 65, 0);
            w2Spell2 = wizard2.item1.AddSpell("golpe", 20, 0);
            w2Spell3 = wizard2.item1.AddSpell("escudo", 0, 30);
        }
        [Test]
        public void DoEncounterTest1()
        {
            // Caso en el que hay menos heroes que enemigos
            bool expected = true;
            int expectedRounds = 6;
            string expectedVictors = "The heroes have won!!";
            List<Heroes> heroes = new List<Heroes> {wizard1, dwarf1, elf};
            List<Enemies> enemies = new List<Enemies> {bomber, darkKnight, darkWizard, golem, gorgon};
            // El método DoEncounter devolvería cuantas rondas duró
            int rounds;
            string victors;
            Battle.DoEncounter(heroes, enemies, out rounds, out victors);
            bool success = (expectedRounds == rounds) && (expectedVictors == victors);
            
            Assert.That(expected, Is.EqualTo(success));
        }
        [Test]
        public void DoEncounterTest2()
        {
            // Caso en el que hay la misma cantidad de heroes que de enemigos
            bool expected = true;
            int expectedRounds = 4;
            string expectedVictors = "The heroes have won!!";
            List<Heroes> heroes = new List<Heroes> {wizard1, wizard2, dwarf1, dwarf2, elf};
            List<Enemies> enemies = new List<Enemies> {bomber, darkKnight, darkWizard, golem, gorgon};

            int rounds;
            string victors;
            Battle.DoEncounter(heroes, enemies, out rounds, out victors);
            bool success = (expectedRounds == rounds) && (expectedVictors == victors);
            
            Assert.That(expected, Is.EqualTo(success));
        }
        [Test]
        public void DoEncounterTest3()
        {
            // Caso en el que hay la misma cantidad de heroes que de enemigos
            bool expected = true;
            int expectedRounds = 4;
            string expectedVictors = "The heroes have won!!";
            List<Heroes> heroes = new List<Heroes> {wizard1, wizard2, dwarf1, dwarf2, elf};
            List<Enemies> enemies = new List<Enemies> {bomber, darkKnight, golem};

            int rounds;
            string victors;
            Battle.DoEncounter(heroes, enemies, out rounds, out victors);
            bool success = (expectedRounds == rounds) && (expectedVictors == victors);
            
            Assert.That(expected, Is.EqualTo(success));
        }
        [Test]
        public void VPTest()
        {
            // Verifico que el aumento de los personajes funcione correctamente
            bool expected = true;
            List<Heroes> heroes = new List<Heroes> {wizard1, dwarf1, elf};
            List<Enemies> enemies = new List<Enemies> {bomber, darkKnight, darkWizard, golem, gorgon};
                                                        // vp=5   vp=5       vp=4       vp=3   vp=4
            int rounds;
            string victors;
            Battle.DoEncounter(heroes, enemies, out rounds, out victors);

            bool success = wizard1.VP == 21 && dwarf1.VP == 0 && elf.VP == 0;
            Assert.That(expected, Is.EqualTo(success));
        }
        [Test]
        public void RestoreHealthTest()
        {
            // Verifico que la salud de wizard sea restaurada, ya que obtuvo más de 5 VP
            double expected = 1000;
            List<Heroes> heroes = new List<Heroes> {wizard1, dwarf1, elf};
            List<Enemies> enemies = new List<Enemies> {bomber, darkKnight, darkWizard, golem, gorgon};
                                                        // vp=5   vp=5       vp=4       vp=3   vp=4
            int rounds;
            string victors;
            Battle.DoEncounter(heroes, enemies, out rounds, out victors);

            double result = wizard1.health;
            Assert.That(expected, Is.EqualTo(result));
        }
        [Test]
        public void CorrectDamageTest1()
        {
            // Verifico que elf haya terminado con la salud correcta según los ataques que recibió
            double expected = 440;
            List<Heroes> heroes = new List<Heroes> {wizard1, dwarf1, elf};
            List<Enemies> enemies = new List<Enemies> {bomber, darkKnight, darkWizard, golem, gorgon};
            int rounds;
            string victors;
            Battle.DoEncounter(heroes, enemies, out rounds, out victors);

            double result = elf.health;
            Assert.That(expected, Is.EqualTo(result));
        }
        [Test]
        public void CorrectDamageTest2()
        {
            // Verifico que dwarf haya termiando con la salud correcta según los ataques que recibió
            double expected = 200;
            List<Heroes> heroes = new List<Heroes> {wizard1, dwarf1, elf};
            List<Enemies> enemies = new List<Enemies> {bomber, darkKnight, darkWizard, golem, gorgon};
            int rounds;
            string victors;
            Battle.DoEncounter(heroes, enemies, out rounds, out victors);

            double result = dwarf1.health;
            Assert.That(expected, Is.EqualTo(result));
        }
    }
}