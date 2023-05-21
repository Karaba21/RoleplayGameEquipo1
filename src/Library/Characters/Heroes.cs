namespace Library
{
    public abstract class Heroes : Character
    {
        public void Heal(double medicine)
        {
            this.health = this.health + medicine;
            if (this.health > 1000)
            {
                this.health = 1000;
            }
        }
        public void RestoreHealth()
        {
            this.health = 1000;
        }
        public void UseAllStrength(Enemies enemy)
        {
            if (enemy.totaldefense < this.totaldamage && this.health > 0)
            {
                enemy.health = enemy.health + enemy.totaldefense - this.totaldamage;
            }
            if (enemy.health <= 0)
            {
                this.VP = this.VP + enemy.VP;
            }
        }
    }
}