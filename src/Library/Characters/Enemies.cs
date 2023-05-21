namespace Library
{
    public abstract class Enemies : Character
    {
        public void UseAllStrength(Heroes hero)
        {
            if (hero.totaldefense < this.totaldamage && this.health > 0)
            {
                hero.health = hero.health + hero.totaldefense - this.totaldamage;
            }
        }
    }
}