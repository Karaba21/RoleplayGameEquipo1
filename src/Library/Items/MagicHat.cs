namespace Library
{
    public class MagicHat : IAttackItem, IDefenseItem
    {
        public string name { get ; set ;}
        public double damage { get ; set ;}
        public double defense { get ; set ;}
        public MagicHat()
        {
            this.name = "Magic Hat";
            this.damage = 0;
            this.defense = 40;
        }
    }
}