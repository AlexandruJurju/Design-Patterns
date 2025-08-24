using FactoryMethod.Iluwatar.Weapons.Products;

namespace FactoryMethod.Iluwatar.Weapons.Factories;

public class OrcBlacksmith : Blacksmith
{
    protected override Weapon CreateWeapon(WeaponType weaponType)
    {
        return weaponType switch
        {
            WeaponType.Sword => new ElfSword(),
            WeaponType.Bow => new ElfBow(),
            _ => throw new ArgumentException($"Unknown weapon type: {weaponType}")
        };
    }
}