namespace Flyweight.Bullets;

public class BulletIntrinsic
{
    public string Texture { get; private set; }
    public string Damage { get; private set; }
    public float Size { get; private set; }

    public BulletIntrinsic(string texture, string damage, float size)
    {
        Texture = texture;
        Damage = damage;
        Size = size;
    }
}