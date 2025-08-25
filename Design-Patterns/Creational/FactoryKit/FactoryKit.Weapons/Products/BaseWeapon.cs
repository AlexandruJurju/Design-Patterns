namespace FactoryKit.Weapons.Products;

public abstract class BaseWeapon
{
    public string Name { get; set; } = null!;
    public WeaponType Type { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Weapon: {Name}");
        Console.WriteLine($"Type: {Type}");
        Console.WriteLine();
    }
}