using System;
using System.Collections.Generic;

namespace Library
{
    public class ConsoleReporter : IReporter
    {
        public void ReportAttack(Character attacker, Character attacked)
        {
            Console.WriteLine($"{attacker.name} attacked {attacked.name} with a strength of {attacker.totalDamage}");
            Console.WriteLine($"{attacked.name}'s health now is {attacked.health}\n");
        }
        public void ReportDuel(Character winner, Character loser)
        {
            Console.WriteLine($"{winner.name} won the duel against {loser.name}!!");
            Console.WriteLine($"{winner.name}'s health has now been restored.\n");
        }
        public void ReportExchange(Character giver, Character receiver, IItems item)
        {
            Console.WriteLine($"{giver.name} and {receiver.name} are exchanging items");
            Console.WriteLine($"{giver.name} gave {receiver.name} their {item}");
        }
    }
}