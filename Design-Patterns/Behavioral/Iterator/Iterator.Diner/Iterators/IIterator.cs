namespace Iterator.Diner.Iterators;

public interface IIterator
{
    bool HasNext();
    MenuItem Next();
}