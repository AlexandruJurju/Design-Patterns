namespace FactoryMethod.Iluwatar.Weapons.Products;

public abstract class Weapon
{
    public string Name { get; set; } = null!;
    public int Damage { get; set; }
    public string Material { get; set; } = null!;
    public WeaponType Type { get; set; }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Weapon: {Name}");
        Console.WriteLine($"Type: {Type}");
        Console.WriteLine($"Damage: {Damage}");
        Console.WriteLine($"Material: {Material}");
        Console.WriteLine();
    }
}