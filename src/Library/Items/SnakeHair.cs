namespace Library
{
    public class SnakeHair : IAttackItem, IDefenseItem
    {
        public string name {get ; set;}
        public double damage { get ; set ;}
        public double defense { get ; set ;}
        public SnakeHair()
        {
            this.name="Snake Hair";
            this.damage = 60;
            this.defense = 20;
        }
    }
}