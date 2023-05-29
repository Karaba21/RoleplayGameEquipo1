namespace Library
{
    public class SpikedDiamondArmor : IAttackItem, IDefenseItem
    {
        public string name {get ; set;}
        public double damage { get ; set ;}
        public double defense { get ; set ;}
        public SpikedDiamondArmor()
        {
            this.name="Spiked Diamond Armor";
            this.damage = 60;
            this.defense = 15;
        }
    }
}