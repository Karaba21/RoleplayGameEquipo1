namespace Library
{
    public class Daggers : IItems
    {
        public double damage { get ; set ;}
        public double defense { get ; set ;}
        public Daggers()
        {
            this.damage = 70;
            this.defense = 20;
        }
    }
}