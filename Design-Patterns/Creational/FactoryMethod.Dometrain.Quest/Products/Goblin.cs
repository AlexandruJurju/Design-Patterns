namespace FactoryMethod.Dometrain.Quest.Products;

public class Goblin : IEnemy
{
    public void Scream()
    {
        Console.WriteLine("Goblin Scream");
    }

    public void Attack()
    {
        Console.WriteLine("Goblin Attack");
    }
}