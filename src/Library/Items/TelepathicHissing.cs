namespace Library
{
    public class TelepathicHissing : IAttackItem, IDefenseItem
    {
        public string name {get ; set;}
        public double damage { get ; set ;}
        public double defense { get ; set ;}
        public TelepathicHissing()
        {
            this.name="Telepathic Hissing";
            this.damage = 25;
            this.defense = 20;
        }
    }
}