namespace Observer.Dometrain.Game.Observers;

public class GameOverScreen(Player subject) : IGameObserver
{
    public void Update()
    {
        var health = subject.Health;
        if (health == 0)
        {
            Console.WriteLine("Game Over");
        }
    }
}