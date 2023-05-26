/*

NO ESTA EN USO

*/
namespace Library
{
    public interface ICharacter
    {
        string name {get;set;}
        double health {get;set;}
        double totalDamage {get;}
        double totalDefense {get;}
        void Heal(double medicine);
        void RestoreHealth();
        void UseAllStrength(ICharacter character);
    }
}