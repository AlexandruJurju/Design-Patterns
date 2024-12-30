namespace Observer.Publications.Repositories;

public class NewspaperRepository : INewspaperRepository
{
    public Newspaper GetRandom()
    {
        Random random = new Random();
        return new Newspaper
        {
            Title = "Newspaper",
            Number = random.Next(1000, 10000)
        };
    }
}