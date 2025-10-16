using FactoryMethod.Dometrain.Quest.Products;

namespace FactoryMethod.Dometrain.Quest.Creators;

public class ManorLevel : Level
{
    public override IEnemy CreateEnemy()
    {
        return new Ghost();
    }
}