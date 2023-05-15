namespace Library
{
    public class Shield : IItems
    {
        public double damage { get ; set ;}
        public double defense { get ; set ;}
        public Shield()
        {
            this.damage = 0;
            this.defense = 80;
        }
    }
}