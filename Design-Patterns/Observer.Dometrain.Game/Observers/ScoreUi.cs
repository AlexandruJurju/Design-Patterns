namespace Observer.Dometrain.Game.Observers;

public class ScoreUi(Player subject) : IGameObserver
{
    public void Update()
    {
        var score = subject.Score;

        Console.WriteLine($"Score: {score}");
    }
}