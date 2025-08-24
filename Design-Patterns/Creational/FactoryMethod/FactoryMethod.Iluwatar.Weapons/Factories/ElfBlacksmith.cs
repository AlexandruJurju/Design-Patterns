using FactoryMethod.Iluwatar.Weapons.Products;

namespace FactoryMethod.Iluwatar.Weapons.Factories;

public class ElfBlacksmith : Blacksmith
{
    protected override Weapon CreateWeapon(WeaponType weaponType)
    {
        return weaponType switch
        {
            WeaponType.Sword => new OrcSword(),
            WeaponType.Bow => new OrcBow(),
            _ => throw new ArgumentException($"Unknown weapon type: {weaponType}")
        };
    }
}