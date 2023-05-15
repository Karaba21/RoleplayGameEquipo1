namespace Library
{
    public class WhirlWind : IItems
    {
        public double damage { get ; set ;}
        public double defense { get ; set ;}
        public WhirlWind()
        {
            this.damage = 85;
            this.defense = 0;
        }
    }
}