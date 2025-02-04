namespace Iterator.BookCollection;

public class BookIterator : IIterator
{
    private readonly BookCollection _books;
    private int _currentIndex = 0;

    public BookIterator(BookCollection books)
    {
        _books = books;
    }

    public string First()
    {
        return _books[0];
    }

    public string Next()
    {
        _currentIndex++;
        if (IsDone()) return null;
        return _books[_currentIndex];
    }

    public bool IsDone()
    {
        return _currentIndex >= _books.Count;
    }

    public string CurrentItem()
    {
        return _books[_currentIndex];
    }
}