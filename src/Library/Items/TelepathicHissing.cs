namespace Library
{
    public class TelepathicHissing : IAttackItem, IDefenseItem
    {
        public double damage { get ; set ;}
        public double defense { get ; set ;}
        public TelepathicHissing()
        {
            this.damage = 25;
            this.defense = 20;
        }
    }
}