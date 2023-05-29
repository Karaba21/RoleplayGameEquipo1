namespace Library
{
    public class Daggers : IAttackItem, IDefenseItem
    {
        public string name { get ; set ;}
        public double damage { get ; set ;}
        public double defense { get ; set ;}
        public Daggers()
        {
            this.name = "Daggers";
            this.damage = 70;
            this.defense = 20;
        }
    }
}