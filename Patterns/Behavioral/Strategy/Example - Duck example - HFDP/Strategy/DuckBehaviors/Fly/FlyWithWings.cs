namespace Strategy.DuckBehaviors.Fly;

public class FlyWithWings : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("fly with wings");
    }
}