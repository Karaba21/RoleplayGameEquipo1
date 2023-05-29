using System;
using System.Collections.Generic;

namespace Library
{
    public class ConsoleReporter : IReporter
    {
        public void ReportDuelSetUp(Character char1, Character char2)
        {
            Console.WriteLine($"{char1.name} and {char2.name} will duel to death");
            Console.WriteLine($"{char1.name}'s health begins at {char1.health} and has a total defense of {char1.totalDefense}.");
            Console.WriteLine($"{char1.name}'s health begins at {char2.health} and has a total defense of {char2.totalDefense}.");
        }
        public void ReportAttack(Character attacker, Character attacked)
        {
            Console.WriteLine($"{attacker.name} attacked {attacked.name} with a strength of {attacker.totalDamage}");
            Console.WriteLine($"{attacked.name}'s health now is {attacked.health}\n");
        }
        public void ReportDuelResult(Character winner, Character loser)
        {
            Console.WriteLine($"{winner.name} won the duel against {loser.name}!!");
            Console.WriteLine($"{winner.name}'s health has now been restored.\n");
        }
        public void ReportExchangeSetup(Character giver, Character receiver)
        {
            Console.WriteLine($"{giver.name} and {receiver.name} are exchanging items");
        }
        public void ReportExchange(Character giver, Character receiver, IItems item)
        {
            Console.WriteLine($"{giver.name} gave {receiver.name} their {item.name}");
        }
    }
}