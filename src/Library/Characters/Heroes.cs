namespace Library
{
    public abstract class Heroes : Character
    {
        public double VPposEncounter { get ; set ;}
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
            if (enemy.health > 0)
            {
                if (enemy.totalDefense < this.totalDamage && this.health > 0)
                {
                    enemy.health = enemy.health + enemy.totalDefense - this.totalDamage;
                }
                if (enemy.health <= 0)
                {
                    this.VPposEncounter = this.VPposEncounter + enemy.VP;
                }
            }
        }
    }
}