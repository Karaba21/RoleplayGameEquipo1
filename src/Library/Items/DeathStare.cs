namespace Library
{
    public class DeathStare : IAttackItem, IDefenseItem
    {
        public double damage { get ; set ;}
        public double defense { get ; set ;}
        public DeathStare()
        {
            this.damage = 105;
            this.defense = 25;
        }
    }
}