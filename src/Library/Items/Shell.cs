namespace Library
{
    public class Shell : IDefenseItem
    {
        public string name { get ; set ;}
        public double defense { get ; set ;}
        public Shell()
        {
            this.name = "Shell";
            this.defense = 60;
        }
    }
}