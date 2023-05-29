namespace Library
{
    public class WhirlWind : IAttackItem
    {
        public string name { get ; set ;}
        public double damage { get ; set ;}
        public WhirlWind()
        {
            this.name = "Whirl Wind";
            this.damage = 90;
        }
    }
}