namespace Library
{
    public class Flail : IAttackItem, IDefenseItem
    {
        public string name {get ; set;}
        public double damage { get ; set ;}
        public double defense { get ; set ;}
        public Flail()
        {
            this.name="Flail";
            this.damage = 85;
            this.defense = 20;
        }
    }
}