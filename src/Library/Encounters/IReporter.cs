namespace Library
{
    public interface IReporter
    {
        void ReportAttack(Character char1, Character char2);
        void ReportDuel(Character winner, Character loser);
        void ReportExchange(Character giver, Character receiver, IItems item);
    }
}