namespace FactoryMethod.Dometrain.Quest.Creators;

// Simple factory
public static class LevelFactory
{
    public static Level CreateLevel(LevelType levelType)
    {
        return levelType switch
        {
            LevelType.Cave => new CaveLevel(),
            LevelType.Manor => new ManorLevel(),
            _ => throw new NotImplementedException()
        };
    }
}

public enum LevelType
{
    Cave,
    Manor
}