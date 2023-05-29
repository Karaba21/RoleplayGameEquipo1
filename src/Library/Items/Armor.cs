namespace Library
{
    public class Armor : IDefenseItem
    {
        public string name { get ; set ;}
        public double defense { get ; set ;}
        public Armor()
        {
            this.name = "Armor";
            this.defense = 35;
        }
    }
}