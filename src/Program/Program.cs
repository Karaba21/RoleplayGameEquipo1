using System;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard wizard = new Wizard("Agus");
            Elf elf = new Elf("Alfo");
            Bomber bomber = new Bomber("Andy");
            Golem golem = new Golem("Nacho");

            Spell spell1 = wizard.item1.AddSpell("ataque", 65, 0);
            Spell spell2 = wizard.item1.AddSpell("golpe", 20, 0);
            Spell spell3 = wizard.item1.AddSpell("escudo", 0, 30);

            // 1st Duel
            Duel firstDuel = new Duel(wizard, bomber);
            Character winner1 = firstDuel.DoEncounter();

            // 2nd Duel
            Duel secondDuel = new Duel(elf, golem);
            Character winner2 = secondDuel.DoEncounter();

            if (winner1 is Heroes)
            {
                if (winner2 is Enemies)
                {
                    // Final
                    Duel finalDuel = new Duel((Heroes)winner1, (Enemies)winner2);
                    finalDuel.DoEncounter();
                }
                if (winner2 is Heroes)
                {
                    Console.WriteLine("Heroes have won the battle!!!");
                }
            }
            if (winner1 is Enemies)
            {
                if (winner2 is Heroes)
                {
                    // Final
                    Duel finalDuel = new Duel((Heroes)winner2, (Enemies)winner1);
                    finalDuel.DoEncounter();
                }
                if (winner2 is Enemies)
                {
                    Console.WriteLine("Heroes have lost :( The enemies have take over)");
                }
            }
        }
    }
}