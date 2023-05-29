namespace Library
{
    public class Sword : IAttackItem, IDefenseItem
    {
        public string name {get ; set;}
        public double damage { get ; set ;}
        public double defense { get ; set ;}
        public Sword()
        {
            this.name="Sword";
            this.damage = 75;
            this.defense = 10;
        }
    }
}