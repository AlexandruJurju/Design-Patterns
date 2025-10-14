using FactoryKit.Weapons.Products;

namespace FactoryKit.Weapons;

public class ItemFactoryKit
{
    private readonly Dictionary<string, Func<BaseWeapon>> _factories = new();

    public ItemFactoryKit Register(WeaponType weaponType, Func<BaseWeapon> factory)
    {
        _factories[weaponType.ToString()] = factory;
        return this;
    }

    public BaseWeapon CreateItem(string itemType)
    {
        if (_factories.TryGetValue(itemType, out var factory))
        {
            return factory();
        }

        throw new ArgumentException($"Unknown item type: {itemType}");
    }

    public IEnumerable<string> GetAvailableItems()
    {
        return _factories.Keys;
    }
}