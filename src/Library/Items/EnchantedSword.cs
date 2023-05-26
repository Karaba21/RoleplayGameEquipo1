namespace Library
{
 public class EnchantedSword: IAttackItem, IDefenseItem
    {
        public double damage { get ; set ;}
        public double defense { get ; set ;}
        public EnchantedSword()
        {
            this.damage = 40;
            this.defense = 5;
        }
    }
}