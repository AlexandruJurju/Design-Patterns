namespace DuckSimulator.Composite;

public class Flock : IQuackable
{
    private List<IQuackable> _ducks = new();

    public void Add(IQuackable duck) => _ducks.Add(duck);

    public void Quack()
    {
        foreach (var duck in _ducks)
        {
            duck.Quack();
        }
    }
}