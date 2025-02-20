using Flyweight.Bullets;

var factory = new BulletFactory();
var bullets = new List<BulletExtrinsic>();

// Create 1000 small bullets
var smallBulletType = factory.GetBulletType("small_bullet.png", "low", 1.0f);
for (int i = 0; i < 1000; i++)
{
    var bullet = new BulletExtrinsic(smallBulletType);
    bullet.SetPosition(
        (float)Random.Shared.NextDouble() * 100,
        (float)Random.Shared.NextDouble() * 100,
        (float)Random.Shared.NextDouble() * 360
    );
    bullets.Add(bullet);
}

// Create 1000 large bullets
var largeBulletType = factory.GetBulletType("large_bullet.png", "high", 2.0f);
for (int i = 0; i < 1000; i++)
{
    var bullet = new BulletExtrinsic(largeBulletType);
    bullet.SetPosition(
        (float)Random.Shared.NextDouble() * 100,
        (float)Random.Shared.NextDouble() * 100,
        (float)Random.Shared.NextDouble() * 360
    );
    bullets.Add(bullet);
}

Console.WriteLine($"Total bullet objects: {bullets.Count}");
Console.WriteLine($"Total bullet types: {factory.GetBulletTypesCount()}");

// Render first few bullets to demonstrate
foreach (var t in bullets)
{
    t.Render();
}