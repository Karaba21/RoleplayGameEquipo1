namespace Library
{
    public class WhirlWind : IAttackItem, IDefenseItem
    {
        public string name {get ; set ;}
        public double damage { get ; set ;}
        public double defense { get ; set ;}
        public WhirlWind()
        {
            this.name="Whirl Wind";
            this.damage = 90;
            this.defense = 0;
        }
    }
}