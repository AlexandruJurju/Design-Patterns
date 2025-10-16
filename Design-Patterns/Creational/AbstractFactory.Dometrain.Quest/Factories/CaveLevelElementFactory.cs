using AbstractFactory.Dometrain.Quest.Products;
using AbstractFactory.Dometrain.Quest.Products.CaveLevel;

namespace AbstractFactory.Dometrain.Quest.Factories;

public class CaveLevelElementFactory : LevelElementFactory
{
    public override IEnemy CreateEnemy()
    {
        return new Goblin();
    }

    public override IWeapon CreateWeapon()
    {
        return new Axe();
    }

    public override IPowerUp CreatePowerUp()
    {
        return new Crystal();
    }
}