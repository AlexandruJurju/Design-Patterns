namespace FactoryMethod.Iluwatar.Weapons.Products;

public class OrcBow : Weapon
{
    public OrcBow()
    {
        Name = "War Bow";
        Type = WeaponType.Bow;
        Damage = 70;
        Material = "Reinforced Wood";
    }
}