using System;
using Library;
using System.Collections.Generic;
using NUnit.Framework;

namespace Library.Test
{
    public class SpellBookTest
    // En esta clase hay 7 tests.
    {
        private SpellBook spellBook;
        private Spell spell1;
        private Spell spell2;
        private Spell spell3;
        [SetUp]
        public void SetUp()
        {
            spellBook = new SpellBook();
            spell1 = new Spell("ataque", 40, 0);
            spell2 = new Spell("golpe", 20, 20);
            spell3 = new Spell("escudo", 0, 30);
        }
        [Test]
        public void AddSpellTest1()
        {
            // Testeo si funciona el agregar hechizos a la lista del libro
            bool expected = true;
            spellBook.AddSpell(spell1);

            Assert.That(expected, Is.EqualTo(spellBook.spells.Contains(spell1)));
        }
        [Test]
        public void AddSpellTest2()
        {
            // Testeo si funciona el aumento del damage del libro al agregar un hechizo
            double expected = 55;
            spellBook.AddSpell(spell1);

            Assert.That(expected, Is.EqualTo(spellBook.damage));
        }
        [Test]
        public void RemoveSpellTest1()
        {
            // Testeo si funciona quitar hechizos de la lista del libro
            bool expected = false;
            spellBook.AddSpell(spell1);
            spellBook.RemoveSpell(spell1);

            Assert.That(expected, Is.EqualTo(spellBook.spells.Contains(spell1)));
        }
        [Test]
        public void RemoveSpellTest2()
        {
            // Testeo si funciona la resta del damage del libro
            double expected = 0;
            spellBook.AddSpell(spell1);
            spellBook.RemoveSpell(spell1);

            Assert.That(expected, Is.EqualTo(spellBook.damage));
        }
        [Test]
        public void RemoveSpellTest3()
        {
            // Testeo si funciona el método cuando un hechizo no esta en el libro
            double expected = 0;
            spellBook.RemoveSpell(spell1);

            Assert.That(expected, Is.EqualTo(spellBook.damage));
        }
        [Test]
        public void MultipleSpellsDamageTest()
        {
            // Testeo que el damage del libro aumenta con la cantidad de hechizos
            double expected = 105;
            spellBook.AddSpell(spell1);
            spellBook.AddSpell(spell2);
            spellBook.AddSpell(spell3);

            Assert.That(expected, Is.EqualTo(spellBook.damage));
        }
        [Test]
        public void MultipleSpellsDefenseTest()
        {
            // Testeo que el defense del libro aumenta con la cantidad de hechizos
            double expected = 65;
            spellBook.AddSpell(spell1);
            spellBook.AddSpell(spell2);
            spellBook.AddSpell(spell3);

            Assert.That(expected, Is.EqualTo(spellBook.defense));
        }
    }
}