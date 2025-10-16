using AbstractFactory.Dometrain.Quest.Factories;

SetupEnvironment(new CaveLevelElementFactory());
SetupEnvironment(new ManorLevelElementFactory());

Console.WriteLine("Hello, World!");

void SetupEnvironment(LevelElementFactory levelElementFactory)
{
    var enemy = levelElementFactory.CreateEnemy();
    var weapon = levelElementFactory.CreateWeapon();
    var powerUp = levelElementFactory.CreatePowerUp();
}