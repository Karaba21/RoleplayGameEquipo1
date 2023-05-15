using System;
using Library;
using System.Collections.Generic;
using NUnit.Framework;

namespace Library.Test
{
    public class SpellBookTest
    // En esta clase hay 7 tests.
    {
        private SpellBook spellbook;
        private Spell spell1;
        private Spell spell2;
        private Spell spell3;
        [SetUp]
        public void SetUp()
        {
            spellbook = new SpellBook();
            spell1 = new Spell("ataque", 40, 0);
            spell2 = new Spell("golpe", 20, 20);
            spell3 = new Spell("escudo", 0, 30);
        }
        [Test]
        public void AddSpellTest1()
        {
            // Testeo si funciona el agregar hechizos a la lista del libro
            bool expected = true;
            spellbook.AddSpell(spell1);

            Assert.That(expected, Is.EqualTo(spellbook.spells.Contains(spell1)));
        }
        [Test]
        public void AddSpellTest2()
        {
            // Testeo si funciona el aumento del damage del libro al agregar un hechizo
            double expected = 15;
            spellbook.AddSpell(spell1);

            Assert.That(expected, Is.EqualTo(spellbook.damage));
        }
        [Test]
        public void RemoveSpellTest1()
        {
            // Testeo si funciona quitar hechizos de la lista del libro
            bool expected = false;
            spellbook.AddSpell(spell1);
            spellbook.RemoveSpell(spell1);

            Assert.That(expected, Is.EqualTo(spellbook.spells.Contains(spell1)));
        }
        [Test]
        public void RemoveSpellTest2()
        {
            // Testeo si funciona la resta del damage del libro
            double expected = 0;
            spellbook.AddSpell(spell1);
            spellbook.RemoveSpell(spell1);

            Assert.That(expected, Is.EqualTo(spellbook.damage));
        }
        [Test]
        public void RemoveSpellTest3()
        {
            // Testeo si funciona el método cuando un hechizo no esta en el libro
            double expected = 0;
            spellbook.RemoveSpell(spell1);

            Assert.That(expected, Is.EqualTo(spellbook.damage));
        }
        [Test]
        public void MultipleSpellsDamageTest()
        {
            // Testeo que el damage del libro aumenta con la cantidad de hechizos
            double expected = 45;
            spellbook.AddSpell(spell1);
            spellbook.AddSpell(spell2);
            spellbook.AddSpell(spell3);

            Assert.That(expected, Is.EqualTo(spellbook.damage));
        }
        [Test]
        public void MultipleSpellsDefenseTest()
        {
            // Testeo que el defense del libro aumenta con la cantidad de hechizos
            double expected = 15;
            spellbook.AddSpell(spell1);
            spellbook.AddSpell(spell2);
            spellbook.AddSpell(spell3);

            Assert.That(expected, Is.EqualTo(spellbook.defense));
        }
    }
}