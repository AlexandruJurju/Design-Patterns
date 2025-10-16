using FactoryMethod.Iluwatar.Weapons.Products;

namespace FactoryMethod.Iluwatar.Weapons.Factories;

public abstract class Blacksmith
{
    protected abstract Weapon CreateWeapon(WeaponType weaponType);

    public Weapon CraftWeapon(WeaponType weaponType)
    {
        Console.WriteLine($"Blacksmith is crafting a {weaponType}...");
        var weapon = CreateWeapon(weaponType);
        Console.WriteLine($"Crafted: {weapon.Name}");
        return weapon;
    }
}