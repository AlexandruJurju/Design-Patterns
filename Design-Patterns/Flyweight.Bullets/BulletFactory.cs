namespace Flyweight.Bullets;

public class BulletFactory
{
    private readonly Dictionary<string, BulletIntrinsic> _bulletTypes = new();

    public BulletIntrinsic GetBulletType(string texture, string damage, float size)
    {
        var key = $"{texture}_{damage}_{size}";

        if (!_bulletTypes.ContainsKey(key))
        {
            Console.WriteLine($"Creating new bullet type: {key}");
            _bulletTypes[key] = new BulletIntrinsic(texture, damage, size);
        }
        else
        {
            Console.WriteLine($"Reusing existing bullet type: {key}");
        }

        return _bulletTypes[key];
    }

    public int GetBulletTypesCount()
    {
        return _bulletTypes.Count;
    }
}