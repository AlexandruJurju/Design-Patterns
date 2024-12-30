namespace Observer.Publications.Repositories;

public class BookRepository : IBookRepository
{
    public Book GetRandom()
    {
        var random = new Random();

        return new Book
        {
            Title = "NewBook",
            Genre = "NewGenre",
            Pages = random.Next(1, 2000),
        };
    }
}