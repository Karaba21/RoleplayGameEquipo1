namespace Library
{
    public abstract class Enemies : Character
    {
        public void RestoreHealth()
        {
            this.health = 1000;
        }
        public void UseAllStrength(Heroes hero)
        {
            if (hero.health > 0)
            {
                if (hero.totalDefense < this.totalDamage && this.health > 0)
                {
                    hero.health = hero.health + hero.totalDefense - this.totalDamage;
                }
            }
        }
    }
}