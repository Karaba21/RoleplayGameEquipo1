namespace Library
{
    public class MagicHat : IAttackItem, IDefenseItem
    {
        public double damage { get ; set ;}
        public double defense { get ; set ;}
        public MagicHat()
        {
            this.damage = 0;
            this.defense = 40;
        }
    }
}