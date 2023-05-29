namespace Library
{
    public class Scythe : IAttackItem, IDefenseItem
    {
        public string name { get ; set ;}
        public double damage { get ; set ;}
        public double defense { get ; set ;}
        public Scythe()
        {
            this.name = "Scythe";
            this.damage = 90;
            this.defense = 15;
        }
    }
}