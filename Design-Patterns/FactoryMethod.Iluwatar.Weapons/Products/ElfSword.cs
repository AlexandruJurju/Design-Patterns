namespace FactoryMethod.Iluwatar.Weapons.Products;

public class ElfSword : Weapon
{
    public ElfSword()
    {
        Name = "Moonlight Blade";
        Type = WeaponType.Sword;
        Damage = 90;
        Material = "Mithril";
    }
}