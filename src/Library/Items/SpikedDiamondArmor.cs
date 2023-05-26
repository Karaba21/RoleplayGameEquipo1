namespace Library
{
    public class SpikedDiamondArmor : IAttackItem, IDefenseItem
    {
        public double damage { get ; set ;}
        public double defense { get ; set ;}
        public SpikedDiamondArmor()
        {
            this.damage = 60;
            this.defense = 15;
        }
    }
}