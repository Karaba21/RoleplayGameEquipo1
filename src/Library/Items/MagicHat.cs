namespace Library
{
    public class MagicHat : IDefenseItem
    {
        public string name { get ; set ;}
        public double defense { get ; set ;}
        public MagicHat()
        {
            this.name = "Magic Hat";
            this.defense = 40;
        }
    }
}