namespace Library
{
    public interface ICharacter
    {
        string name {get;set;}
        double health {get;set;}
        double totaldamage {get;}
        double totaldefense {get;}
        void Heal(double medicine);
        void RestoreHealth();
        void UseAllStrength(ICharacter character);
    }
}