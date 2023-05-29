namespace Library
{
    public class Shield : IAttackItem, IDefenseItem
    {
        public string name { get ; set ;}
        public double damage { get ; set ;}
        public double defense { get ; set ;}
        public Shield()
        {
            this.name = "Shield";
            this.damage = 0;
            this.defense = 50;
        }
    }
}