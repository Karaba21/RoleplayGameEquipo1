namespace Library
{
    public class SnakeHair : IAttackItem, IDefenseItem
    {
        public double damage { get ; set ;}
        public double defense { get ; set ;}
        public SnakeHair()
        {
            this.damage = 60;
            this.defense = 20;
        }
    }
}