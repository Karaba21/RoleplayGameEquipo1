namespace Library
{
    public class Armor : IDefenseItem
    {
        public double defense { get ; set ;}
        public Armor()
        {
            this.defense = 35;
        }
    }
}