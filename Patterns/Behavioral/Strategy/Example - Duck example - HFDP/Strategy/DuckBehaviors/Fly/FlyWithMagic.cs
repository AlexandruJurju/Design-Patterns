namespace Strategy.DuckBehaviors.Fly;

public class FlyWithMagic : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("flying with magic");
    }
}