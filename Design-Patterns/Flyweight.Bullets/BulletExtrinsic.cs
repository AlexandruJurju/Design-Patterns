namespace Flyweight.Bullets;

public class BulletExtrinsic
{
    private BulletIntrinsic _bulletIntrinsic;
    private float _xPosition;
    private float _yPosition;
    private float _direction;

    public BulletExtrinsic(BulletIntrinsic bulletIntrinsic)
    {
        _bulletIntrinsic = bulletIntrinsic;
    }

    public void SetPosition(float x, float y, float direction)
    {
        _xPosition = x;
        _yPosition = y;
        _direction = direction;
    }

    public void Render()
    {
        Console.WriteLine($"Drawing bullet at ({_xPosition}, {_yPosition}) " +
                          $"facing {_direction} degrees with texture {_bulletIntrinsic.Texture}, " +
                          $"damage {_bulletIntrinsic.Damage}, size {_bulletIntrinsic.Size}");
    }
}