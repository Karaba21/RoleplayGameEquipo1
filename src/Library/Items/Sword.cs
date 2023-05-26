namespace Library
{
    public class Sword : IAttackItem, IDefenseItem
    {
        public double damage { get ; set ;}
        public double defense { get ; set ;}
        public Sword()
        {
            this.damage = 75;
            this.defense = 10;
        }
    }
}