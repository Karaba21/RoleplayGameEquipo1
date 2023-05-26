namespace Library
{
    public class Flail : IAttackItem, IDefenseItem
    {
        public double damage { get ; set ;}
        public double defense { get ; set ;}
        public Flail()
        {
            this.damage = 85;
            this.defense = 20;
        }
    }
}