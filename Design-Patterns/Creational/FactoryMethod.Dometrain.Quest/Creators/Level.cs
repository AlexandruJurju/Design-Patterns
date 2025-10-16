using FactoryMethod.Dometrain.Quest.Products;

namespace FactoryMethod.Dometrain.Quest.Creators;

public abstract class Level
{
    public abstract IEnemy CreateEnemy();

    public void EncounterEnemy()
    {
        var enemy = CreateEnemy();
        enemy.Scream();
        enemy.Attack();
    }
}