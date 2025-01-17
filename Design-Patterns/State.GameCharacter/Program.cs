using State.GameCharacter;

var hero = new Character(); // Normal State

Console.WriteLine($"Initial health: {hero.Health}");

hero.TakeDamage(30);
Console.WriteLine($"After damage: {hero.Health}");

hero.CollectPowerUp();
Console.WriteLine($"After damage: {hero.Health}, has power up: {hero.HasPowerUp}");

hero.TakeDamage(30);
Console.WriteLine($"After damage: {hero.Health}, has power up: {hero.HasPowerUp}");

for (var i = 0; i < 12; i++)
{
    hero.Update();
}

Console.WriteLine($"After 12 turns: {hero.Health}, has power up: {hero.HasPowerUp}");

hero.TakeDamage(70);
Console.WriteLine($"After damage: {hero.Health}");