namespace Library
{
    public class Shield : IAttackItem, IDefenseItem
    {
        public double damage { get ; set ;}
        public double defense { get ; set ;}
        public Shield()
        {
            this.damage = 0;
            this.defense = 50;
        }
    }
}