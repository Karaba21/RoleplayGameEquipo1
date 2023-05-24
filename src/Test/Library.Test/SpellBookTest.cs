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
        }
        [Test]
        public void AddSpellTest1()
        {
            // Testeo si funciona el agregar hechizos a la lista del libro
            bool expected = true;
            spell1 = spellBook.AddSpell("ataque", 40, 0);

            Assert.That(expected, Is.EqualTo(spellBook.spells.Contains(spell1)));
        }
        [Test]
        public void AddSpellTest2()
        {
            // Testeo si funciona el aumento del damage del libro al agregar un hechizo
            double expected = 55;
            spell1 = spellBook.AddSpell("ataque", 40, 0);

            Assert.That(expected, Is.EqualTo(spellBook.damage));
        }
        [Test]
        public void RemoveSpellTest1()
        {
            // Testeo si funciona quitar hechizos de la lista del libro
            bool expected = false;
            spell1 = spellBook.AddSpell("ataque", 40, 0);
            spellBook.RemoveSpell(spell1);

            Assert.That(expected, Is.EqualTo(spellBook.spells.Contains(spell1)));
        }
        [Test]
        public void RemoveSpellTest2()
        {
            // Testeo si funciona la resta del damage del libro
            double expected = 0;
            spell1 = spellBook.AddSpell("ataque", 40, 0);
            spellBook.RemoveSpell(spell1);

            Assert.That(expected, Is.EqualTo(spellBook.damage));
        }
        [Test]
        public void RemoveSpellTest3()
        {
            // Testeo si funciona el método cuando un hechizo no esta en el libro
            double expected = 0;
            Spell testSpell = new Spell("ataque", 40, 0);
            spellBook.RemoveSpell(spell1);

            Assert.That(expected, Is.EqualTo(spellBook.damage));
        }
        [Test]
        public void MultipleSpellsDamageTest()
        {
            // Testeo que el damage del libro aumenta con la cantidad de hechizos
            double expected = 105;
            spell1 = spellBook.AddSpell("ataque", 40, 0);
            spell2 = spellBook.AddSpell("golpe", 20, 20);
            spell3 = spellBook.AddSpell("escudo", 0, 30);

            Assert.That(expected, Is.EqualTo(spellBook.damage));
        }
        [Test]
        public void MultipleSpellsDefenseTest()
        {
            // Testeo que el defense del libro aumenta con la cantidad de hechizos
            double expected = 65;
            spell1 = spellBook.AddSpell("ataque", 40, 0);
            spell2 = spellBook.AddSpell("golpe", 20, 20);
            spell3 = spellBook.AddSpell("escudo", 0, 30);

            Assert.That(expected, Is.EqualTo(spellBook.defense));
        }
    }
}