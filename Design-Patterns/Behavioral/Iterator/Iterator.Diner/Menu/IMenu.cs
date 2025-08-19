using Iterator.Diner.Iterators;

namespace Iterator.Diner.Menu;

public interface IMenu
{
    IIterator CreateIterator();
}