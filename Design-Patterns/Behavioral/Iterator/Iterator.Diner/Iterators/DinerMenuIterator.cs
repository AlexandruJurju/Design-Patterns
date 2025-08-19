namespace Iterator.Diner.Iterators;

public class DinerMenuIterator : IIterator
{
    private readonly MenuItem[] _items;
    private int _position;

    public DinerMenuIterator(MenuItem[] items)
    {
        _items = items;
    }

    public bool HasNext()
    {
        return _position < _items.Length && _items[_position] != null;
    }

    public MenuItem Next()
    {
        return _items[_position++];
    }
}