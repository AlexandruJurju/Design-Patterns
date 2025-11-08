using AbstractFactory.Dometrain.Quest.Products;

namespace AbstractFactory.Dometrain.Quest.Factories;

public abstract class LevelElementFactory
{
    public abstract IEnemy CreateEnemy();
    public abstract IWeapon CreateWeapon();
    public abstract IPowerUp CreatePowerUp();
}