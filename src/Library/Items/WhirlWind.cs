namespace Library
{
    public class WhirlWind : IAttackItem, IDefenseItem
    {
        public double damage { get ; set ;}
        public double defense { get ; set ;}
        public WhirlWind()
        {
            this.damage = 90;
            this.defense = 0;
        }
    }
}