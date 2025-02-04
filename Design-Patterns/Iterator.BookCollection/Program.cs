using Iterator.BookCollection;

var books = new BookCollection();
books.Add("Design Patterns");
books.Add("Clean Code");
books.Add("Refactoring");

var iterator = books.CreateIterator();

while (!iterator.IsDone())
{
    Console.WriteLine(iterator.CurrentItem());
    iterator.Next();
}