namespace Library
{
    public class FireBalls : IAttackItem, IDefenseItem
    {
        public double damage { get ; set ;}
        public double defense { get ; set ;}
        public FireBalls()
        {
            this.damage = 85;
            this.defense = 5;
        }
    }
}