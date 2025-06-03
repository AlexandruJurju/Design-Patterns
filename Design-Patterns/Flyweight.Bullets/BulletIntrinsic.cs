namespace Flyweight.Bullets;

public class BulletIntrinsic
{
    public BulletIntrinsic(string texture, string damage, float size)
    {
        Texture = texture;
        Damage = damage;
        Size = size;
    }

    public string Texture { get; private set; }
    public string Damage { get; private set; }
    public float Size { get; private set; }
}