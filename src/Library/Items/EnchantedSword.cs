namespace Library
{
 public class EnchantedSword: IAttackItem, IDefenseItem
    {
        public string name { get ; set ;}
        public double damage { get ; set ;}
        public double defense { get ; set ;}
        public EnchantedSword()
        {
            this.name = "Enchanted Sword";
            this.damage = 40;
            this.defense = 5;
        }
    }
}
