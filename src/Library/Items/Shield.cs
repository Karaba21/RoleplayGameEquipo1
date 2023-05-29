namespace Library
{
    public class Shield : IDefenseItem
    {
        public string name { get ; set ;}
        public double defense { get ; set ;}
        public Shield()
        {
            this.name = "Shield";
            this.defense = 50;
        }
    }
}