namespace Iterator.BookCollection;

public interface IIterator
{
    string First();
    string Next();
    bool IsDone();
    string CurrentItem();
}