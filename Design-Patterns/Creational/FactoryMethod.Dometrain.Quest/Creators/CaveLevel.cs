using FactoryMethod.Dometrain.Quest.Products;

namespace FactoryMethod.Dometrain.Quest.Creators;

public class CaveLevel : Level
{
    public override IEnemy CreateEnemy()
    {
        return new Goblin();
    }
}