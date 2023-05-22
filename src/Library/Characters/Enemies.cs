namespace Library
{
    public abstract class Enemies : Character
    {
        public void UseAllStrength(Heroes hero)
        {
            if (hero.totalDefense < this.totalDamage && this.health > 0)
            {
                hero.health = hero.health + hero.totalDefense - this.totalDamage;
            }
        }
    }
}