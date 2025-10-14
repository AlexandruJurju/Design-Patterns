using FactoryKit.Weapons.Products;

namespace FactoryKit.Weapons;

public class ItemFactoryBuilder
{
    public static ItemFactoryKit CreateWeaponKit()
    {
        return new ItemFactoryKit()
            .Register(WeaponType.Sword, () => new Sword())
            .Register(WeaponType.Axe, () => new Axe())
            .Register(WeaponType.Bow, () => new Bow())
            .Register(WeaponType.Spear, () => new Spear());
    }
}