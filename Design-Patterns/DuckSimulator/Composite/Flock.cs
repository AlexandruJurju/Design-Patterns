namespace DuckSimulator.Composite;

public class Flock : IQuackable
{
    private readonly List<IQuackable> _ducks = new();

    public void Quack()
    {
        foreach (var duck in _ducks)
        {
            duck.Quack();
        }
    }

    public void Add(IQuackable duck)
    {
        _ducks.Add(duck);
    }
}