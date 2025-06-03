namespace Iterator.BookCollection;

public class BookCollection : IBookCollection
{
    private readonly List<string> _titles = new();

    public int Count => _titles.Count;

    public string this[int index] => _titles[index];

    public IIterator CreateIterator()
    {
        return new BookIterator(this);
    }

    public void Add(string title)
    {
        _titles.Add(title);
    }
}