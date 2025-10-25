namespace Observer.Dometrain.Game;

public class Player : IGameSubject
{
    private readonly IList<IGameObserver> _observers = new List<IGameObserver>();
    public int Health { get; private set; }
    public int Score { get; private set; }

    public void SetState(int health, int score)
    {
        Health = health;
        Score = score;
        Notify();
    }

    public void Attach(IGameObserver gameObserver)
    {
        _observers.Add(gameObserver);
    }

    public void Detach(IGameObserver gameObserver)
    {
        _observers.Remove(gameObserver);
    }

    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update();
        }
    }
}