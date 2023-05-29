namespace Library
{
    public interface IReporter
    {
        void ReportDuelSetUp(Character char1, Character char2);
        void ReportAttack(Character attacker, Character attacked);
        void ReportDuelResult(Character winner, Character loser);
        void ReportExchangeSetup(Character giver, Character receiver);
        void ReportExchange(Character giver, Character receiver, IItems item);
    }
}