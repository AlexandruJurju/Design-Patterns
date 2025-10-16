namespace FactoryMethod.Dometrain.Quest.Products;

public class Ghost : IEnemy
{
    public void Scream()
    {
        Console.WriteLine("Ghost Scream");
    }

    public void Attack()
    {
        Console.WriteLine("Ghost Attack");
    }
}