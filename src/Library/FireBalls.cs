namespace Library
{
    public class FireBalls : IItems
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