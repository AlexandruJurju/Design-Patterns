namespace FactoryMethod.Iluwatar.Weapons.Products;

public class OrcSword : Weapon
{
    public OrcSword()
    {
        Name = "Brutal Cleaver";
        Type = WeaponType.Sword;
        Damage = 85;
        Material = "Crude Iron";
    }
}