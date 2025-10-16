using AbstractFactory.Dometrain.Quest.Products;
using AbstractFactory.Dometrain.Quest.Products.CaveLevel;
using AbstractFactory.Dometrain.Quest.Products.ManorLevel;

namespace AbstractFactory.Dometrain.Quest.Factories;

public class ManorLevelElementFactory : LevelElementFactory
{
    public override IEnemy CreateEnemy()
    {
        return new Ghost();
    }

    public override IWeapon CreateWeapon()
    {
        return new Staff();
    }

    public override IPowerUp CreatePowerUp()
    {
        return new Crystal();
    }
}