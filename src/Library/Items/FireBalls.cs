namespace Library
{
    public class FireBalls : IAttackItem, IDefenseItem
    {
        public string name { get ; set ;}
        public double damage { get ; set ;}
        public double defense { get ; set ;}
        public FireBalls()
        {
            this.name = "Fire Fists";
            this.damage = 85;
            this.defense = 5;
        }
    }
}