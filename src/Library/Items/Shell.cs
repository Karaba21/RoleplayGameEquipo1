namespace Library
{
    public class Shell : IDefenseItem
    {
        public double defense { get ; set ;}
        public Shell()
        {
            this.defense = 60;
        }
    }
}