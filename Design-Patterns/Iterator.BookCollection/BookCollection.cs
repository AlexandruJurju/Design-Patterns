namespace Iterator.BookCollection;

public class BookCollection : IBookCollection
{
    private List<string> _titles = new();

    public void Add(string title)
    {
        _titles.Add(title);
    }

    public IIterator CreateIterator()
    {
        return new BookIterator(this);
    }

    public int Count => _titles.Count;

    public string this[int index] => _titles[index];
}