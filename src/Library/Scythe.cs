namespace Library
{
    public class Scythe : IItems
    {
        public double damage { get ; set ;}
        public double defense { get ; set ;}
        public Scythe()
        {
            this.damage = 90;
            this.defense = 15;
        }
    }
}