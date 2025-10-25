namespace Observer.Dometrain.Game.Observers;

public class HealthUi(Player subject) : IGameObserver
{
    public void Update()
    {
        var health = subject.Health;
        Console.WriteLine($"Health: {health}");
    }
}