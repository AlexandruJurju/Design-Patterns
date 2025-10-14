namespace FactoryMethod.Iluwatar.Weapons.Products;

public class ElfBow : Weapon
{
    public ElfBow()
    {
        Name = "Starfall Longbow";
        Type = WeaponType.Bow;
        Damage = 100;
        Material = "Ancient Yew";
    }
}